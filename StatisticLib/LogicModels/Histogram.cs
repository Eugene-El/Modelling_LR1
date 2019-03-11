using StatisticLib.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticLib.LogicModels
{
    public class Histogram
    {
        public List<Range> Ranges { get; private set; }
        public double RangesFrom { get; private set; }
        public double RangesTo { get; private set; }
        public int MaxCount { get { return Ranges.Max(r => r.Count); } }

        public Histogram(List<double> values, uint rangeCount = 15)
        {
            double range = (values.Max() - values.Min()) / rangeCount;

            Ranges = new List<Range>();
            for (int i = 0; i < rangeCount; i++)
            {
                Ranges.Add(new Range(values.Min() + i * range, values.Min() + (i + 1) * range));
            }
            foreach(var val in values)
            {
                foreach(var rangee in Ranges)
                {
                    if (rangee.AddValueIfAble(val)) break;
                }
            }
            
        }
    }
}
