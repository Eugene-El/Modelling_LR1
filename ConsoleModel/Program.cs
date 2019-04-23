using GenerationLib;
using ModellingLib;
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
            Model model = new Model(
                new ErlangGenerator(0.25, 3),
                new PoissonGenerator(0.5),
                new NormalGenerator(14, 1.5),
                new ExponentialGenerator(3),
                new ModelTime() { Time = 500 }
                );

            model.Run();

            model.Drain.DrainedTransacts.ForEach(t => Console.WriteLine(t));

            /*
            AbstractGenerator generator = new NormalGenerator();

            var values = generator.Next(1000000);
            Console.WriteLine("Max: {0}\nMin: {1}\nAverage: {2}",
                values.Max(), values.Min(), values.Average());

            Histogram hist = new Histogram(values, 50);
            hist.Draw(DrawMode.SaveAndOpen, 1000, 700);
            */


            Console.ReadLine();
        }
    }
}
