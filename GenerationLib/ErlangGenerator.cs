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
        private int _l; // n
 
        public ErlangGenerator(double lambda = 1, int l = 3)
        {
            _exponentialGenerator = new ExponentialGenerator(lambda);
            _l = l;
        }

        public ErlangGenerator(int seed, double lambda = 1, int l = 3)
        {
            _exponentialGenerator = new ExponentialGenerator(seed, lambda);
            _l = l;
        }

        public override double Next()
        {
            double val = 0;
            for(int i = 0; i < _l; i++)
                val += _exponentialGenerator.Next();
            return val;
        }
    }
}
