using GenerationLib;
using ModellingLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModellingApplication
{
    public partial class ModellingMainForm : Form
    {
        private Model _model;

        public ModellingMainForm()
        {
            InitializeComponent();
        }

        private void modelBtn_Click(object sender, EventArgs e)
        {
            _model = new Model(
                new ErlangGenerator(0.25, 3),
                new PoissonGenerator(0.5),
                new NormalGenerator(14, 1.5),
                new ExponentialGenerator(3),
                new ModelTime() { Time = 500 }
            );

            _model.Run();

            transactsBox.DataSource = _model.Drain.DrainedTransacts;

            var logs = _model.Drain.DrainedTransacts.SelectMany(dt => dt.GetJournal().Select(log => new ModelLog()
            {
                TransactId = dt.Id,
                Type = dt.Type,
                Event = log.Event,
                Time = log.Time.Time
            })).ToList();
            logs.Sort((log1, log2) =>
            {
                int compare = log1.Time.CompareTo(log2.Time);
                if (compare == 0) return ((int)log1.Event).CompareTo((int)log2.Event);
                return compare;
            });
            modelLogsBox.DataSource = logs;
        }

        private void transactsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tran = transactsBox.SelectedItem as Transact;
            transactStoryBox.DataSource = tran.GetJournal();
        }
    }
}
