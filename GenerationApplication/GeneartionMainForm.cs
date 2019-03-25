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
            string distribution = distributionCmb.Text;
            bool useRandomSeed = useRandomSeedCheck.Checked;
            int seed = (int)seedNumeric.Value;

            Task.Factory.StartNew(() =>
            {

                AbstractGenerator generator;
                switch (distribution)
                {
                    case "Uniform":
                        {
                            generator = useRandomSeed ? new UniformGenerator() : new UniformGenerator(seed);
                            break;
                        }
                    case "Exponential":
                        {
                            generator = useRandomSeed ? new ExponentialGenerator() : new ExponentialGenerator(seed);
                            break;
                        }
                    case "Erlang":
                        {
                            generator = useRandomSeed ? new ErlangGenerator() : new ErlangGenerator(seed);
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
        
    }
}
