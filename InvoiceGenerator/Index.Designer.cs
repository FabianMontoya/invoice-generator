namespace InvoiceGenerator
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtExcelFile = new TextBox();
            btnExcelFileSelector = new Button();
            label1 = new Label();
            openFileDialog = new OpenFileDialog();
            cbWorkSheets = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbColumnsHeaders = new ComboBox();
            label3 = new Label();
            btnDocxFileSelector = new Button();
            txtDocxFile = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            cbDocumentFields = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(342, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtExcelFile
            // 
            txtExcelFile.Location = new Point(10, 59);
            txtExcelFile.Name = "txtExcelFile";
            txtExcelFile.ReadOnly = true;
            txtExcelFile.Size = new Size(158, 23);
            txtExcelFile.TabIndex = 1;
            // 
            // btnExcelFileSelector
            // 
            btnExcelFileSelector.Cursor = Cursors.Hand;
            btnExcelFileSelector.Location = new Point(174, 58);
            btnExcelFileSelector.Name = "btnExcelFileSelector";
            btnExcelFileSelector.Size = new Size(128, 23);
            btnExcelFileSelector.TabIndex = 2;
            btnExcelFileSelector.Text = "Seleccione archivo";
            btnExcelFileSelector.UseVisualStyleBackColor = true;
            btnExcelFileSelector.Click += btnExcelFileSelector_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(243, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione archivo excel con registros (.xlsx):";
            // 
            // openFileDialog
            // 
            openFileDialog.Title = "Seleccione archivo Excel";
            // 
            // cbWorkSheets
            // 
            cbWorkSheets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWorkSheets.FormattingEnabled = true;
            cbWorkSheets.Location = new Point(9, 44);
            cbWorkSheets.Name = "cbWorkSheets";
            cbWorkSheets.Size = new Size(158, 23);
            cbWorkSheets.TabIndex = 4;
            cbWorkSheets.SelectedIndexChanged += cbWorkSheets_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 21);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 5;
            label2.Text = "Indique la hoja con los datos:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbColumnsHeaders);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbWorkSheets);
            groupBox1.Location = new Point(13, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Excel";
            // 
            // cbColumnsHeaders
            // 
            cbColumnsHeaders.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColumnsHeaders.FormattingEnabled = true;
            cbColumnsHeaders.Location = new Point(173, 44);
            cbColumnsHeaders.Name = "cbColumnsHeaders";
            cbColumnsHeaders.Size = new Size(158, 23);
            cbColumnsHeaders.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 35);
            label3.Name = "label3";
            label3.Size = new Size(219, 15);
            label3.TabIndex = 9;
            label3.Text = "Seleccione la plantilla de factura (.docx):";
            // 
            // btnDocxFileSelector
            // 
            btnDocxFileSelector.Cursor = Cursors.Hand;
            btnDocxFileSelector.Location = new Point(546, 58);
            btnDocxFileSelector.Name = "btnDocxFileSelector";
            btnDocxFileSelector.Size = new Size(128, 23);
            btnDocxFileSelector.TabIndex = 8;
            btnDocxFileSelector.Text = "Seleccione archivo";
            btnDocxFileSelector.UseVisualStyleBackColor = true;
            btnDocxFileSelector.Click += btnDocxFileSelector_Click;
            // 
            // txtDocxFile
            // 
            txtDocxFile.Location = new Point(382, 59);
            txtDocxFile.Name = "txtDocxFile";
            txtDocxFile.ReadOnly = true;
            txtDocxFile.Size = new Size(158, 23);
            txtDocxFile.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDocxFile);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnExcelFileSelector);
            groupBox2.Controls.Add(btnDocxFileSelector);
            groupBox2.Controls.Add(txtExcelFile);
            groupBox2.Location = new Point(13, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(720, 110);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Archivos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cbDocumentFields);
            groupBox3.Location = new Point(385, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 100);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 19);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 5;
            label4.Text = "Indique la hoja con los datos:";
            // 
            // cbDocumentFields
            // 
            cbDocumentFields.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDocumentFields.FormattingEnabled = true;
            cbDocumentFields.Location = new Point(9, 42);
            cbDocumentFields.Name = "cbDocumentFields";
            cbDocumentFields.Size = new Size(190, 23);
            cbDocumentFields.TabIndex = 4;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 361);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            FormClosed += Index_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox txtExcelFile;
        private Button btnExcelFileSelector;
        private Label label1;
        private OpenFileDialog openFileDialog;
        private ComboBox cbWorkSheets;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox cbColumnsHeaders;
        private Label label3;
        private Button btnDocxFileSelector;
        private TextBox txtDocxFile;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox cbDocumentFields;
    }
}