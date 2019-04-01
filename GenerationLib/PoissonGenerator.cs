using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class PoissonGenerator : AbstractGenerator
    {
        private UniformGenerator _uniformGenerator;
        private double _lambda;
        private int _k;

        public PoissonGenerator(double lambda = 1)
        {
            _uniformGenerator = new UniformGenerator();
            _lambda = lambda;
        }

        public PoissonGenerator(int seed, double lambda = 1)
        {
            _uniformGenerator = new UniformGenerator(seed);
            _lambda = lambda;
        }

        public override double Next()
        {
            return -Math.Log(_uniformGenerator.Next()) / _lambda;

            /*
            double p = 1.0, L = Math.Exp(-_lambda);
            int k = 0;
            do
            {
                k++;
                p *= _uniformGenerator.Next();
            }
            while (p > L);
            return k - 1;
            */

            /*
            double temp = Math.Pow(_lambda, _k) / Math.Pow(Math.E, -_lambda);
            int i = _k;
            while (i > 0) // Factrorial
            {
                temp /= i;
                i--;
            }
            return temp;
            */
        }
    }
}
