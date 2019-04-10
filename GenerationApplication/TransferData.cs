using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationApplication
{
    public class TransferData
    {
        public List<double> Numbers { get; set; }
        public DistributionEnum Distribution { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double Lambda { get; set; }
        public int N { get; set; }
        public double Mu { get; set; }
        public double Sigma { get; set; }
    }
}
