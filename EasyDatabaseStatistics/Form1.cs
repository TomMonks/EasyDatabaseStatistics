using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CustomGUI.Textbox;
using EasyDatabase.MSAccess;
using EasyDatabase.SQL;

namespace EasyDatabaseStatistics
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.textboxWithOpenFileDialog1.Args = new TextBoxWithOpenAccessDialogArgs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textboxWithOpenFileDialog1.Text != "")
            {
                var db = new AccessDatabase(this.textboxWithOpenFileDialog1.Text);

                this.accessSystemDataGridView1.GetSchema(db, AccessDatabaseCollections.Tables);
                this.accessSystemDataGridView2.GetSchema(db, AccessDatabaseCollections.Queries);
            }
        }


    }
}
