using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class ErlangGenerator : AbstractGenerator
    {
        private ExponentialGenerator _exponentialGenerator;
        private int _n;
 
        public ErlangGenerator(double lambda = 1, int n = 3)
        {
            _exponentialGenerator = new ExponentialGenerator(lambda);
            _n = n;
        }

        public ErlangGenerator(int seed, double lambda = 1, int n = 3)
        {
            _exponentialGenerator = new ExponentialGenerator(seed, lambda);
            _n = n;
        }

        public override double Next()
        {
            double val = 0;
            for(int i = 0; i < _n; i++)
                val += _exponentialGenerator.Next();
            return val;
        }
    }
}
