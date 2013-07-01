namespace EasyDatabaseStatistics
{
    partial class Form1
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
            CustomGUI.Textbox.TextBoxWithOpenExcelDialogArgs textBoxWithOpenExcelDialogArgs1 = new CustomGUI.Textbox.TextBoxWithOpenExcelDialogArgs();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extendedTabControl1 = new CustomGUI.ExtendedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxWithOpenFileDialog1 = new CustomGUI.TextboxWithOpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.accessSystemDataGridView2 = new EasyDatabase.MSAccess.AccessSystemDataGridView();
            this.accessSystemDataGridView1 = new EasyDatabase.MSAccess.AccessSystemDataGridView();
            this.extendedTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessSystemDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessSystemDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // extendedTabControl1
            // 
            this.extendedTabControl1.Controls.Add(this.tabPage1);
            this.extendedTabControl1.Location = new System.Drawing.Point(12, 12);
            this.extendedTabControl1.Name = "extendedTabControl1";
            this.extendedTabControl1.SelectedIndex = 0;
            this.extendedTabControl1.Size = new System.Drawing.Size(797, 485);
            this.extendedTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.accessSystemDataGridView2);
            this.tabPage1.Controls.Add(this.accessSystemDataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textboxWithOpenFileDialog1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxWithOpenFileDialog1
            // 
            textBoxWithOpenExcelDialogArgs1.Filter = "Excel Workbooks (.xls, .xlxs)|*.xls,*.xlsx";
            textBoxWithOpenExcelDialogArgs1.Title = "Open Excel Workbook";
            this.textboxWithOpenFileDialog1.Args = textBoxWithOpenExcelDialogArgs1;
            this.textboxWithOpenFileDialog1.Location = new System.Drawing.Point(74, 22);
            this.textboxWithOpenFileDialog1.Name = "textboxWithOpenFileDialog1";
            this.textboxWithOpenFileDialog1.Size = new System.Drawing.Size(628, 32);
            this.textboxWithOpenFileDialog1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Access File";
            // 
            // accessSystemDataGridView2
            // 
            this.accessSystemDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessSystemDataGridView2.Location = new System.Drawing.Point(347, 60);
            this.accessSystemDataGridView2.Name = "accessSystemDataGridView2";
            this.accessSystemDataGridView2.Size = new System.Drawing.Size(343, 224);
            this.accessSystemDataGridView2.TabIndex = 8;
            // 
            // accessSystemDataGridView1
            // 
            this.accessSystemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessSystemDataGridView1.Location = new System.Drawing.Point(10, 60);
            this.accessSystemDataGridView1.Name = "accessSystemDataGridView1";
            this.accessSystemDataGridView1.Size = new System.Drawing.Size(331, 224);
            this.accessSystemDataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 509);
            this.Controls.Add(this.extendedTabControl1);
            this.Name = "Form1";
            this.Text = "Easy Database Statistics Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.extendedTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessSystemDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessSystemDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomGUI.TextboxWithOpenFileDialog textboxWithOpenFileDialog1;
        private CustomGUI.ExtendedTabControl extendedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private EasyDatabase.MSAccess.AccessSystemDataGridView accessSystemDataGridView1;
        private EasyDatabase.MSAccess.AccessSystemDataGridView accessSystemDataGridView2;
        
    }
}

