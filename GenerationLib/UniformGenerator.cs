using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public class UniformGenerator : AbstractGenerator
    {
        private Random _random;
        private double _a;
        private double _b;

        public UniformGenerator(double a = 0, double b = 1)
        {
            _random = new Random();
            _a = a;
            _b = b;
        }

        public UniformGenerator(int seed, double a = 0, double b = 1)
        {
            _random = new Random(seed);
            _a = a;
            _b = b;
        }

        public override double Next()
        {
            return (double)_random.Next() / int.MaxValue / (_b - _a);
        }
    }
}
