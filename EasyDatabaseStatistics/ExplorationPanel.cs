using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataVisualisation;
using DataVisualisation.CrossTab;

namespace EasyDatabaseStatistics
{
    public partial class ExplorationPanel : UserControl
    {

        protected CrossTabDataTable crossTab;

        public ExplorationPanel()
        {
            InitializeComponent();
        }



        public void SetCrossTab(CrossTabDataTable crossTab)
        {
            this.crossTabView.DataSource = crossTab;
            this.crossTab = crossTab;
        }

        public void SetAggregateResults(BasicStatisticsVisualiser visualiser)
        {
            this.statisticsDataGridView1.SetStatisticsVisualiser(visualiser); 
 
        }

        private void ExplorationPanel_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.crossTab.DisplaySummaryStatistic(this.comboBox1.Text);
        }
    }
}
