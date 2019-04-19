using GenerationLib;
using StatisticLib.LogicModels;
using StatisticSimpleVisualizationLib;
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
    public partial class GeneartionMainForm : Form
    {
        private Color _backgroundColor = Color.FromArgb(184, 174, 212); 
        private Color _foregroundColor = Color.FromArgb(38, 104, 87);

        public GeneartionMainForm()
        {
            InitializeComponent();

            BitmapDrawExtension.BackgroundColor = _backgroundColor;
            BitmapDrawExtension.HistogramColor = _foregroundColor;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            
            string distribution = distributionTabControl.SelectedTab.Text;
            bool useRandomSeed = useRandomSeedCheck.Checked;
            int seed = (int)seedNumeric.Value;

            Task.Factory.StartNew(() =>
            {

                AbstractGenerator generator;
                switch (distribution)
                {
                    case "Uniform":
                        {
                            double a = (double)aNumeric.Value;
                            double b = (double)bNumeric.Value;
                            generator = useRandomSeed ? new UniformGenerator(a, b) : new UniformGenerator(seed, a, b);
                            break;
                        }
                    case "Exponential":
                        {
                            double lambda = (double)lambdaNumeric.Value;
                            generator = useRandomSeed ? new ExponentialGenerator(lambda) : new ExponentialGenerator(seed, lambda);
                            break;
                        }
                    case "Erlang":
                        {
                            double lambda = (double)lambdaErlangNumeric.Value;
                            int n = (int)nNumeric.Value;
                            generator = useRandomSeed ? new ErlangGenerator(lambda, n) : new ErlangGenerator(seed, lambda, n);
                            break;
                        }
                    case "Normal":
                        {
                            double m = (double)mNumeric.Value;
                            double sigma = (double)sigmaNumeric.Value;
                            generator = useRandomSeed ? new NormalGenerator(m, sigma) : new NormalGenerator(seed, m, sigma);
                            break; 
                        }
                    case "Poisson":
                        {
                            double lambda = (double)poissonLambdaNumeric.Value;
                            generator = useRandomSeed ? new PoissonGenerator(lambda) : new PoissonGenerator(seed, lambda);
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }

                var numbers = generator.Next((int)elementsCountNumeric.Value);

                Histogram histogram = new Histogram(numbers, (uint)groupCountNumeric.Value);
                Image histogramImage = histogram.Draw(StatisticSimpleVisualizationLib.DrawMode.ReturnBitmap,
                    (int)widthNumeric.Value,
                    (int)heightNumeric.Value)
                    as Image;

                numberPageList.Invoke((MethodInvoker)delegate
                {
                    numberPageList.NumberList = numbers;
                });
                histogramPicBox.Invoke((MethodInvoker)delegate {
                    histogramPicBox.Image?.Dispose();
                    histogramPicBox.Image = histogramImage;
                });
            });
            generateReportBtn.Enabled = true;

        }

        private void useRandomSeedCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                seedNumeric.Visible = false;
            }
            else
            {
                seedNumeric.Value = (int)(DateTime.Now.Ticks);
                seedNumeric.Visible = true;
            }
        }

        private void groupBoxesPaint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(_backgroundColor);
            e.Graphics.DrawRectangle(new Pen(_foregroundColor), box.DisplayRectangle);
            e.Graphics.DrawString(box.Text, box.Font, new SolidBrush(_foregroundColor), 0, 0);
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            string distribution = distributionTabControl.SelectedTab.Text;
            TransferData transferData = null;

            switch (distribution)
            {
                case "Uniform":
                    {
                        transferData = new TransferData()
                        {
                            A = (double)aNumeric.Value,
                            B = (double)bNumeric.Value,
                            Distribution = DistributionEnum.Uniform
                        };
                        break;
                    }
                case "Exponential":
                    {
                        transferData = new TransferData()
                        {
                            Lambda = (double)lambdaNumeric.Value,
                            Distribution = DistributionEnum.Exponential
                        };
                        break;
                    }
                case "Erlang":
                    {
                        transferData = new TransferData()
                        {
                            Lambda = (double)lambdaErlangNumeric.Value,
                            N = (int)nNumeric.Value,
                            Distribution = DistributionEnum.Erlang
                        };
                        break;
                    }
                case "Normal":
                    {
                        transferData = new TransferData()
                        {
                            Mu = (double)mNumeric.Value,
                            Sigma = (double)sigmaNumeric.Value,
                            Distribution = DistributionEnum.Normal
                        };
                        break;
                    }
                case "Poisson":
                    {
                        transferData = new TransferData()
                        {
                            Lambda = (double)poissonLambdaNumeric.Value,
                            Distribution = DistributionEnum.Poisson
                        };
                        break;
                    }
            }

            if (transferData != null)
            {
                transferData.Numbers = numberPageList.NumberList;
                new ReportForm(transferData).Show();
            }
        }
    }
}
