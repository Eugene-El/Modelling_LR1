using Accord.Math.Random;
using Accord.Statistics.Distributions.Univariate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerationApplication
{
    public partial class ReportForm : Form
    {
        private TransferData _transferData;

        public ReportForm(TransferData transferData)
        {
            _transferData = transferData;

            InitializeComponent();

            GetStandartStatistic();
        }

        private void GetStandartStatistic()
        {
            nLbl.Text = _transferData.Numbers.Count.ToString();
            minLbl.Text = _transferData.Numbers.Min().ToString();
            maxLbl.Text = _transferData.Numbers.Max().ToString();
            meanLbl.Text = _transferData.Numbers.Average().ToString();

            stdDevLbl.Text = Math.Sqrt(
                _transferData.Numbers.Sum((num) => { return Math.Pow(num - _transferData.Numbers.Average(), 2); })
                / _transferData.Numbers.Count)
                .ToString();

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            double alpha = (double)alphaNumeric.Value;
            double opgBorder = Math.Sqrt(-Math.Log( (1-alpha) / 2) / 2);

            opgLbl.Text = "(0; " + opgBorder.ToString() + ")";


            IRandomNumberGenerator<double> generator;

            switch (_transferData.Distribution)
            {
                case DistributionEnum.Uniform:
                    {
                        generator = new UniformContinuousDistribution(_transferData.A, _transferData.B);
                        break;
                    }
                case DistributionEnum.Exponential:
                    {
                        generator = new ExponentialDistribution(_transferData.Lambda);
                        break;
                    }
                case DistributionEnum.Erlang:
                    {
                        generator = new GammaDistribution(1 / _transferData.Lambda, _transferData.N);
                        break;
                    }
                case DistributionEnum.Normal:
                    {
                        generator = new NormalDistribution(_transferData.Mu, _transferData.Sigma);
                        break;
                    }
                case DistributionEnum.Poisson:
                    {
                        generator = new PoissonDistribution(_transferData.Lambda);
                        break;
                    }
                default: return;
            }

            double KS = GetKolmogorovSmirnov( generator.Generate(_transferData.Numbers.Count).ToList() );

            ksLbl.Text = KS.ToString();
        }


        private double GetKolmogorovSmirnov(List<double> list)
        {
            // Check count
            if (_transferData.Numbers.Count != list.Count)
                throw new Exception("Diferent count of numbers in samples");

            // Sort samples
            _transferData.Numbers.Sort();
            list.Sort();

            // Get max distance
            double D = 0;
            for (int i = 0; i < _transferData.Numbers.Count; i++)
            {
                double dif = Math.Abs(_transferData.Numbers[i] - list[i]);
                if (dif > D)
                    D = dif;
            }

            // Get Kolmogorov Smirnov
            return D * Math.Sqrt(Math.Pow(list.Count, 2) / (2 * list.Count));
        }
    }
    
}
