using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    public partial class Index : Form
    {

        FileManager fmExcel;
        FileManager fmDocx;

        public Index()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            fmExcel = new FileManager();
            fmDocx = new FileManager();
        }



        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmExcel.DeleteFilesInFolder();
            Environment.Exit(0);
        }


        private void btnExcelFileSelector_Click(object sender, EventArgs e)
        {
            ResetData();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (fmExcel.MoveFileToTempFolder(openFileDialog.FileName))
                {
                    txtExcelFile.Text = openFileDialog.SafeFileName;
                    ProcessLoadedExcel();
                }
                else
                {
                    MessageBox.Show("Lo sentimos, pero hubo un error al intentar copiar el archivo seleccionado.", "Error al copiar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnExcelFileSelector.Text = txtExcelFile.Text.Length > 0 ? "Cambiar archivo" : "Seleccione archivo";
        }

        private void ResetData()
        {
            txtExcelFile.Text = "";
            fmExcel.DeleteTempFile();
            cbWorkSheets.Items.Clear();
            cbWorkSheets.SelectedIndex = -1;
            cbColumnsHeaders.Items.Clear();
            cbColumnsHeaders.SelectedIndex = -1;
        }

        XLWorkbook global_wb;

        private void ProcessLoadedExcel()
        {
            global_wb = new XLWorkbook(fmExcel.GetFilePath());

            var workheets = global_wb.Worksheets;

            if (workheets.Count == 0)
            {
                MessageBox.Show("El archivo seleccionado no contiene hojas, por favor verifiquelo e intente cargarlo de nuevo.", "Archivo sin hojas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            foreach (var w in workheets)
            {
                if (w != null)
                {
                    cbWorkSheets.Items.Add(w.ToString());

                }
            }
        }

        private void GetColumnsHeadersFromWorkSheet(int worsksheetIndex)
        {
            var wsData = global_wb.Worksheet(worsksheetIndex);

            // Look for the first row used
            var firstRowUsed = wsData.FirstRowUsed();

            if (firstRowUsed == null)
            {
                MessageBox.Show($"Lo sentimos, la hoja seleccionada [{cbWorkSheets.SelectedItem}] no tiene datos para procesar.\nFavor validar o intenta seleccionar otra hoja del Excel.", "Hoja sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var headers = firstRowUsed.CellsUsed();

            if (headers == null)
            {
                MessageBox.Show($"Lo sentimos, no se logró identificar los headers de la hoja seleccionada.\nFavor validar o intenta seleccionar otra hoja del Excel.", "Hoja sin cabeceras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<HeaderObject> wsHeaders = new List<HeaderObject>();

            foreach (var col in headers)
            {
                var cellId = col.Address.ToString();
                if (cellId != null)
                {
                    string headerName = col.GetString();
                    var headerObject = new HeaderObject(cellId, headerName);
                    wsHeaders.Add(headerObject);

                    var cbItem = new ComboboxItem();
                    cbItem.Text = headerName;
                    cbItem.Value = headerObject;

                    cbColumnsHeaders.Items.Add(cbItem);
                }
            }

        }

        private void cbWorkSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbColumnsHeaders.Items.Clear();
            cbColumnsHeaders.SelectedIndex = -1;

            if (cbWorkSheets.SelectedIndex > -1)
            {
                GetColumnsHeadersFromWorkSheet(cbWorkSheets.SelectedIndex + 1);
            }
        }

        private void btnDocxFileSelector_Click(object sender, EventArgs e)
        {
            fmDocx.DeleteTempFile();

            openFileDialog.Filter = "Word Files|*.doc;*.docx;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (fmDocx.MoveFileToTempFolder(openFileDialog.FileName))
                {
                    txtDocxFile.Text = openFileDialog.SafeFileName;
                }
                else
                {
                    MessageBox.Show("Lo sentimos, pero hubo un error al intentar copiar el archivo seleccionado.", "Error al copiar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class HeaderObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public HeaderObject(string id, string name)
        {
            this.id = id;
            this.name = name;
        }


    }

}
