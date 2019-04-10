using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class PoissonGenerator : AbstractGenerator
    {
        private ExponentialGenerator _exponentialGenerator;
        private double _lambda;

        public PoissonGenerator(double lambda = 1)
        {
            _exponentialGenerator = new ExponentialGenerator(lambda);
            _lambda = lambda;
        }

        public PoissonGenerator(int seed, double lambda = 1)
        {
            _exponentialGenerator = new ExponentialGenerator(seed, lambda);
            _lambda = lambda;
        }

        public override double Next()
        {
            return _exponentialGenerator.Next();
        }
    }
}
