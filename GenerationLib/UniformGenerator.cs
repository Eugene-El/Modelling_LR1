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

        public UniformGenerator()
        {
            _random = new Random();
        }

        public UniformGenerator(int seed)
        {
            _random = new Random(seed);
        }

        public override double Next()
        {
            return (double)_random.Next() / int.MaxValue;
        }
    }
}
