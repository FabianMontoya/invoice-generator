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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(363, 257);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtExcelFile
            // 
            txtExcelFile.Location = new Point(13, 93);
            txtExcelFile.Name = "txtExcelFile";
            txtExcelFile.ReadOnly = true;
            txtExcelFile.Size = new Size(158, 23);
            txtExcelFile.TabIndex = 1;
            // 
            // btnExcelFileSelector
            // 
            btnExcelFileSelector.Cursor = Cursors.Hand;
            btnExcelFileSelector.Location = new Point(177, 92);
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
            label1.Location = new Point(12, 69);
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
            cbWorkSheets.Location = new Point(6, 42);
            cbWorkSheets.Name = "cbWorkSheets";
            cbWorkSheets.Size = new Size(158, 23);
            cbWorkSheets.TabIndex = 4;
            cbWorkSheets.SelectedIndexChanged += cbWorkSheets_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
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
            groupBox1.Location = new Point(21, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cbColumnsHeaders
            // 
            cbColumnsHeaders.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColumnsHeaders.FormattingEnabled = true;
            cbColumnsHeaders.Location = new Point(170, 42);
            cbColumnsHeaders.Name = "cbColumnsHeaders";
            cbColumnsHeaders.Size = new Size(158, 23);
            cbColumnsHeaders.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 70);
            label3.Name = "label3";
            label3.Size = new Size(219, 15);
            label3.TabIndex = 9;
            label3.Text = "Seleccione la plantilla de factura (.docx):";
            // 
            // btnDocxFileSelector
            // 
            btnDocxFileSelector.Cursor = Cursors.Hand;
            btnDocxFileSelector.Location = new Point(485, 93);
            btnDocxFileSelector.Name = "btnDocxFileSelector";
            btnDocxFileSelector.Size = new Size(128, 23);
            btnDocxFileSelector.TabIndex = 8;
            btnDocxFileSelector.Text = "Seleccione archivo";
            btnDocxFileSelector.UseVisualStyleBackColor = true;
            btnDocxFileSelector.Click += btnDocxFileSelector_Click;
            // 
            // txtDocxFile
            // 
            txtDocxFile.Location = new Point(321, 94);
            txtDocxFile.Name = "txtDocxFile";
            txtDocxFile.ReadOnly = true;
            txtDocxFile.Size = new Size(158, 23);
            txtDocxFile.TabIndex = 7;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 361);
            Controls.Add(label3);
            Controls.Add(btnDocxFileSelector);
            Controls.Add(txtDocxFile);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnExcelFileSelector);
            Controls.Add(txtExcelFile);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            FormClosed += Index_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}