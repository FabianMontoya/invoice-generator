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

        public Index()
        {
            InitializeComponent();
            VerifyTemFileFolder();
        }

        private void VerifyTemFileFolder()
        {
            string initialPath = $"{Application.StartupPath}tempFiles";
            Console.WriteLine($"initialPath: {initialPath}");

            if (!Directory.Exists(initialPath))
            {
                Directory.CreateDirectory(initialPath);
            }
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnExcelFileSelector_Click(object sender, EventArgs e)
        {
            txtExcelFile.Text = "";

            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogExcel.FileName;
                txtExcelFile.Text = openFileDialogExcel.SafeFileName;
            }
        }
    }
}
