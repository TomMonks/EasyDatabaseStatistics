namespace EasyDatabaseStatistics
{
    partial class VisualQueryBuilder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accessObjectDataGridView1 = new EasyDatabase.MSAccess.AccessObjectDataGridView();
            this.accessSchemaViewer1 = new EasyDatabase.MSAccess.AccessSchemaViewer();
            this.accessObjectDataGridView2 = new EasyDatabase.MSAccess.AccessObjectDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accessObjectDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessObjectDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "3. Select field for subgroup rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "2. Select field within table for statistical analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "1. Select table or view containing data";
            // 
            // accessObjectDataGridView1
            // 
            this.accessObjectDataGridView1.AllowUserToAddRows = false;
            this.accessObjectDataGridView1.AllowUserToDeleteRows = false;
            this.accessObjectDataGridView1.AllowUserToResizeColumns = false;
            this.accessObjectDataGridView1.AllowUserToResizeRows = false;
            this.accessObjectDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accessObjectDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessObjectDataGridView1.Location = new System.Drawing.Point(575, 6);
            this.accessObjectDataGridView1.Name = "accessObjectDataGridView1";
            this.accessObjectDataGridView1.RowHeadersVisible = false;
            this.accessObjectDataGridView1.Size = new System.Drawing.Size(273, 212);
            this.accessObjectDataGridView1.TabIndex = 11;
            // 
            // accessSchemaViewer1
            // 
            this.accessSchemaViewer1.Database = null;
            this.accessSchemaViewer1.Location = new System.Drawing.Point(3, 3);
            this.accessSchemaViewer1.Mode = EasyDatabase.MSAccess.AccessSchemaViewer.SchemaMode.Tables;
            this.accessSchemaViewer1.Name = "accessSchemaViewer1";
            this.accessSchemaViewer1.Size = new System.Drawing.Size(571, 218);
            this.accessSchemaViewer1.TabIndex = 10;
            // 
            // accessObjectDataGridView2
            // 
            this.accessObjectDataGridView2.AllowUserToAddRows = false;
            this.accessObjectDataGridView2.AllowUserToDeleteRows = false;
            this.accessObjectDataGridView2.AllowUserToResizeColumns = false;
            this.accessObjectDataGridView2.AllowUserToResizeRows = false;
            this.accessObjectDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accessObjectDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessObjectDataGridView2.Location = new System.Drawing.Point(854, 6);
            this.accessObjectDataGridView2.Name = "accessObjectDataGridView2";
            this.accessObjectDataGridView2.RowHeadersVisible = false;
            this.accessObjectDataGridView2.Size = new System.Drawing.Size(273, 212);
            this.accessObjectDataGridView2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "3. Select field for subgroup columns";
            // 
            // VisualQueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessObjectDataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accessObjectDataGridView1);
            this.Controls.Add(this.accessSchemaViewer1);
            this.Name = "VisualQueryBuilder";
            this.Size = new System.Drawing.Size(1130, 246);
            this.Load += new System.EventHandler(this.VisualQueryBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accessObjectDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessObjectDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private EasyDatabase.MSAccess.AccessObjectDataGridView accessObjectDataGridView1;
        private EasyDatabase.MSAccess.AccessSchemaViewer accessSchemaViewer1;
        private EasyDatabase.MSAccess.AccessObjectDataGridView accessObjectDataGridView2;
        private System.Windows.Forms.Label label4;

    }
}
