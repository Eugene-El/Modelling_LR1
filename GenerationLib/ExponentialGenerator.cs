using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class ExponentialGenerator : AbstractGenerator
    {
        private UniformGenerator _uniformGenerator;
        private double _lambda;

        public ExponentialGenerator(double lambda = 1)
        {
            _uniformGenerator = new UniformGenerator();
            _lambda = lambda;
        }

        public ExponentialGenerator(int seed, double lambda = 1)
        {
            _uniformGenerator = new UniformGenerator(seed);
            _lambda = lambda;
        }

        public override double Next()
        {
            //return _lambda * Math.Pow(Math.E, -_lambda * _uniformGenerator.Next());
            return Math.Log(1 - _uniformGenerator.Next()) / -_lambda;
        }
    }
}
