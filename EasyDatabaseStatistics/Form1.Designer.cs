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
            CustomGUI.Textbox.TextBoxWithOpenExcelDialogArgs textBoxWithOpenExcelDialogArgs6 = new CustomGUI.Textbox.TextBoxWithOpenExcelDialogArgs();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extendedTabControl1 = new CustomGUI.ExtendedTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.visualQueryBuilder1 = new EasyDatabaseStatistics.VisualQueryBuilder();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxWithOpenFileDialog1 = new CustomGUI.TextboxWithOpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.explorationPanel1 = new EasyDatabaseStatistics.ExplorationPanel();
            this.extendedTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.extendedTabControl1.Controls.Add(this.tabPage4);
            this.extendedTabControl1.Location = new System.Drawing.Point(12, 12);
            this.extendedTabControl1.Name = "extendedTabControl1";
            this.extendedTabControl1.SelectedIndex = 0;
            this.extendedTabControl1.Size = new System.Drawing.Size(1214, 660);
            this.extendedTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.visualQueryBuilder1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textboxWithOpenFileDialog1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1206, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // visualQueryBuilder1
            // 
            this.visualQueryBuilder1.Database = null;
            this.visualQueryBuilder1.Location = new System.Drawing.Point(6, 60);
            this.visualQueryBuilder1.Name = "visualQueryBuilder1";
            this.visualQueryBuilder1.Size = new System.Drawing.Size(1130, 246);
            this.visualQueryBuilder1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1025, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get Statistics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxWithOpenFileDialog1
            // 
            textBoxWithOpenExcelDialogArgs6.Filter = "Excel Workbooks (.xls, .xlxs)|*.xls,*.xlsx";
            textBoxWithOpenExcelDialogArgs6.Title = "Open Excel Workbook";
            this.textboxWithOpenFileDialog1.Args = textBoxWithOpenExcelDialogArgs6;
            this.textboxWithOpenFileDialog1.Location = new System.Drawing.Point(74, 22);
            this.textboxWithOpenFileDialog1.Name = "textboxWithOpenFileDialog1";
            this.textboxWithOpenFileDialog1.Size = new System.Drawing.Size(864, 32);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.explorationPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1206, 634);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // explorationPanel1
            // 
            this.explorationPanel1.Location = new System.Drawing.Point(-4, 0);
            this.explorationPanel1.Name = "explorationPanel1";
            this.explorationPanel1.Size = new System.Drawing.Size(999, 627);
            this.explorationPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 662);
            this.Controls.Add(this.extendedTabControl1);
            this.Name = "Form1";
            this.Text = "Easy Database Statistics Tool";
            this.extendedTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomGUI.TextboxWithOpenFileDialog textboxWithOpenFileDialog1;
        private CustomGUI.ExtendedTabControl extendedTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VisualQueryBuilder visualQueryBuilder1;
        private System.Windows.Forms.TabPage tabPage4;
        private ExplorationPanel explorationPanel1;
        
    }
}

