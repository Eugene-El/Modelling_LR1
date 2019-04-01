using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class NormalGenerator : AbstractGenerator
    {
        private UniformGenerator _uniformGenerator;
        private double _m;
        private double _sigma;

        public NormalGenerator(double m = 0, double sigma = 1)
        {
            _uniformGenerator = new UniformGenerator();
            _m = m;
            _sigma = sigma;
        }

        public NormalGenerator(int seed, double m = 0, double sigma = 1)
        {
            _uniformGenerator = new UniformGenerator(seed);
            _m = m;
            _sigma = sigma;
        }

        public override double Next()
        {
            return (_uniformGenerator.Next(12).Sum() - 6) * _sigma + _m;
            
            //return Math.Pow(Math.E, -Math.Pow(_uniformGenerator.Next() - _m, 2) / (2 * Math.Pow(_sigma, 2)) ) / Math.Sqrt(2 * Math.PI * Math.Pow(_sigma, 2));
        }
    }
}
