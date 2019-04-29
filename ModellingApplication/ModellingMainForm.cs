using GenerationLib;
using ModellingApplication.Extensions;
using ModellingApplication.Models;
using ModellingLib;
using ModellingLib.Logs;
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
                new ErlangGenerator(0.25d, 3),
                new PoissonGenerator(0.5d),
                new NormalGenerator(14d, 1.5d),
                new ExponentialGenerator(3d),
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

            trLifeTimeLbl.Text = tran.GetLifeTime().ToString();
            trWaitLbl.Text = tran.GetTimeInQueue().ToString();
            trServerTimeLbl.Text = tran.GetTimeInServer().ToString();
        }
    }
}
