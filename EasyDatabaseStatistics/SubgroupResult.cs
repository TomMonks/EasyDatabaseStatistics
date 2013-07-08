using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDatabaseStatistics
{
    /// <summary>
    /// Container class for subgroup results
    /// </summary>
    public class SubgroupResult
    {
        public string Subgroup { get; set; }
        public double Mean { get; set; }
        public double StDev { get; set; }
        public double Median { get; set; }
        public double IQR { get; set; }
        public double LowerQuartile { get; set; }
        public double UpperQuartile { get; set; }
        public double FifthPercentile { get; set; }
        public double NintyFifthPercentile { get; set; }

        public SubgroupResult() { }
    }
}
