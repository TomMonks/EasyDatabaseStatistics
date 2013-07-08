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
using Statistics.Descriptive;
using DataVisualisation.CrossTab;

namespace EasyDatabaseStatistics
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.textboxWithOpenFileDialog1.Args = new TextBoxWithOpenAccessDialogArgs();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textboxWithOpenFileDialog1.Text != "")
            {
                var db = new AccessDatabase(this.textboxWithOpenFileDialog1.Text);

                this.visualQueryBuilder1.Database = db;
                this.visualQueryBuilder1.GetSchema();


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            Console.WriteLine("Building query....");
            var factory = new SimpleSQLFactory(this.visualQueryBuilder1.SelectedTableName, new List<string>() 
            { 
                this.visualQueryBuilder1.SelectedFieldName, 
                this.visualQueryBuilder1.SelectedRowGroupingFieldName,
                this.visualQueryBuilder1.SelectedColGroupingFieldName 
            });

            var db = new AccessDatabase(this.textboxWithOpenFileDialog1.Text);
            var builder = new StandardQueryBuilder(factory);
            Console.WriteLine("Retrieving data from access...");
            DataTable results = db.ExecuteQuery(builder.BuildSQL());



            try
            {
                Console.WriteLine("Calculating aggregate statistics");
                var statistics = new BasicStatistics(results, 0);
                var visualiser = new DataVisualisation.BasicStatisticsVisualiser(statistics);
                this.explorationPanel1.SetAggregateResults(visualiser);
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message +
                        " Please make sure you have selected quantitative variables for the analysis", "Error analysing query dataset",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message +
                            " Please make sure you have selected quantitative variables for the analysis", "Error analysing query dataset",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


            var adapter = new DataTableToCrossTabAdapter(results, new DataTableToCrossTabAdapterArgs() 
            { 
                RowFieldNames = new List<string>(){this.visualQueryBuilder1.SelectedRowGroupingFieldName}, 
                ColFieldNames = new List<string>(){this.visualQueryBuilder1.SelectedColGroupingFieldName} 
            });

            Console.WriteLine("Building crosstab...");

            var ctDataTable = new CrossTabDataTable(adapter, this.visualQueryBuilder1.SelectedRowGroupingFieldName);
            this.explorationPanel1.SetCrossTab(ctDataTable);
            this.extendedTabControl1.SelectedTab = this.tabPage4;

            Console.WriteLine("Complete.");
        }


        private DataTable GetDistinct(string fieldName)
        {
            this.Cursor = Cursors.WaitCursor;
            var factory = new SimpleDistinctSQLFactory(this.visualQueryBuilder1.SelectedTableName, new List<string>() { fieldName });
            var db = new AccessDatabase(this.textboxWithOpenFileDialog1.Text);
            var builder = new StandardQueryBuilder(factory);
            DataTable results = db.ExecuteQuery(builder.BuildSQL());

            this.Cursor = Cursors.Default;

            return results;
        }


    }
}
