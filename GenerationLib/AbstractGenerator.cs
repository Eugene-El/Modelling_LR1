using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationLib
{
    public abstract class AbstractGenerator
    {
        public abstract double Next();

        public List<double> Next(int count)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < count; i++)
                list.Add(Next());
            return list;
        }
    }
}
