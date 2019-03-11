using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticLib.DataModels
{
    public class Range
    {
        public double From { get; private set; }
        public double To { get; private set; }
        public int Count { get { return list.Count; } }

        private List<double> list;

        public Range(double from, double to)
        {
            From = from;
            To = to;

            list = new List<double>();
        }

        public bool AddValueIfAble(double value)
        {
            if (From <= value && value <= To)
            {
                list.Add(value);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Range ({0}, {1}) - Count: {2} ", From, To, Count);
        }

    }
}
