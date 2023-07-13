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

        FileManager fm;

        public Index()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            fm = new FileManager();
        }



        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.DeleteFilesInFolder();
            Environment.Exit(0);
        }


        private void btnExcelFileSelector_Click(object sender, EventArgs e)
        {
            ResetData();

            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {

                if (fm.MoveFileToTempFolder(openFileDialogExcel.FileName))
                {
                    txtExcelFile.Text = openFileDialogExcel.SafeFileName;
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
            fm.DeleteTempFile();
            cbWorkSheets.Items.Clear();
            cbWorkSheets.SelectedIndex = -1;
        }

        XLWorkbook global_wb;

        private void ProcessLoadedExcel()
        {
            global_wb = new XLWorkbook(fm.GetFilePath());

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

            var headers = firstRowUsed.CellsUsed();


            List<HeaderObject> wsHeaders = new List<HeaderObject>();

            foreach (var col in headers)
            {
                if (col.Address != null)
                {
                    var headerName = col.GetString();
                    var cellId = col.Address.ToString();
                    wsHeaders.Add(new HeaderObject(cellId, headerName));
                }
            }

        }

        private void cbWorkSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWorkSheets.SelectedIndex > -1)
            {
                GetColumnsHeadersFromWorkSheet(cbWorkSheets.SelectedIndex + 1);
            }
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
