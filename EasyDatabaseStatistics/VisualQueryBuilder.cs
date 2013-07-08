using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyDatabase;
using EasyDatabase.MSAccess;
using EasyDatabase.SQL;

namespace EasyDatabaseStatistics
{
    /// <summary>
    /// A user control for creating SQL to retrieve data from Access.  The control provides the user with 
    /// a the ability to select a table, field (for analysis) and a subgroup (e.g. if there are three types of patient - three analyses are conducted). 
    /// </summary>
    public partial class VisualQueryBuilder : UserControl
    {

        #region Properties

        public IDatabase Database
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the table containg the data to be analysed
        /// </summary>
        public string SelectedTableName
        {
            get
            {
                return this.accessSchemaViewer1.TableName;
            }
        }


        /// <summary>
        /// The name of the field within the selected table to be analysed
        /// </summary>
        public string SelectedFieldName
        {
            get
            {
                return this.accessSchemaViewer1.FieldName;
            }
        }


        /// <summary>
        /// The name of the field to split the analysis into subgroup (e.g. perform analysis across different types of patient)
        /// </summary>
        public string SelectedRowGroupingFieldName
        {
            get
            {
                return this.accessObjectDataGridView1.SelectedCells[0].Value.ToString();
            }
        }


        /// <summary>
        /// The name of the field to split the analysis into subgroup (e.g. perform analysis across different types of patient)
        /// </summary>
        public string SelectedColGroupingFieldName
        {
            get
            {
                return this.accessObjectDataGridView2.SelectedCells[0].Value.ToString();
            }
        }

        public VisualQueryBuilder()
        {
            InitializeComponent();
            
        }

        #endregion

        public void TableSelected(object sender, DataGridViewCellEventArgs args)
        {
            this.GetObjectSchema(this.accessSchemaViewer1.TableName);
        }

        private void GetObjectSchema(string tableName)
        {

            ValidateDatabase();

            var factory = new AccessObjectSQLFactory() { ObjectName = tableName };
            this.accessObjectDataGridView1.Database = this.Database;
            this.accessObjectDataGridView1.Query = new StandardQueryBuilder(factory);
            this.accessObjectDataGridView1.Execute();


            this.accessObjectDataGridView2.DataSource = ((DataTable)this.accessObjectDataGridView1.DataSource).Copy();
        }

        private void ValidateDatabase()
        {
            if (null == this.Database)
            {
                throw new NullReferenceException("Database parameter must be set before attempting to retrieve schema");
            }
        }


        /// <summary>
        /// Retrieve the database schema.
        /// </summary>
        public void GetSchema()
        {

            ValidateDatabase();

            this.accessSchemaViewer1.Database = this.Database;
            this.accessSchemaViewer1.GetSchema();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void VisualQueryBuilder_Load(object sender, EventArgs e)
        {
            this.accessSchemaViewer1.OnTableSelectEvent += this.TableSelected;
        }
    }
}
