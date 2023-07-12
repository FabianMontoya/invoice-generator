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
            txtExcelFile.Text = "";
            fm.DeleteTempFile();

            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {

                if (fm.MoveFileToTempFolder(openFileDialogExcel.FileName))
                {
                    txtExcelFile.Text = openFileDialogExcel.SafeFileName;
                }
                else
                {
                    MessageBox.Show("Lo sentimos, pero hubo un error al intentar copiar el archivo seleccionado.", "Error al copiar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnExcelFileSelector.Text = txtExcelFile.Text.Length > 0 ? "Cambiar archivo" : "Seleccione archivo";

        }
    }
}
