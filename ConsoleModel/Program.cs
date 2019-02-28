using GenerationLib;
using StatisticLib.LogicModels;
using StatisticSimpleVisualizationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleModel
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractGenerator generator = new UniformGenerator();
            
            Histogram hist = new Histogram(generator.Next(1000000), 50);
            hist.Draw(DrawMode.SaveAndOpen, 1000, 700);

            Console.ReadLine();
        }
    }
}
