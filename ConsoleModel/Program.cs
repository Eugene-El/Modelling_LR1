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
            AbstractGenerator generator = new NormalGenerator();
            

            var values = generator.Next(1000000);
            Console.WriteLine("Max: {0}\nMin: {1}\nAverage: {2}",
                values.Max(), values.Min(), values.Average());

            Histogram hist = new Histogram(values, 50);
            hist.Draw(DrawMode.SaveAndOpen, 1000, 700);

            Console.ReadLine();
        }
    }
}
