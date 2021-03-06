﻿using GenerationLib;
using ModellingApplication.Extensions;
using ModellingApplication.Models;
using ModellingLib;
using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            int modelTime = 500;
            _model = new Model(
                new ErlangGenerator(0.25d, 3),
                new PoissonGenerator(0.5d),
                new NormalGenerator(14d, 1.5d),
                new ExponentialGenerator(3d),
                new ModelTime() { Time = modelTime }
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

            transactCountLbl.Text = _model.Drain.DrainedTransacts.Count.ToString();
            avgLifeTimeLbl.Text = (_model.Drain.DrainedTransacts.Sum(t => t.GetLifeTime())
                / _model.Drain.DrainedTransacts.Count).ToString();
            avgTimeInQueueLbl.Text = (_model.Drain.DrainedTransacts.Sum(t => t.GetTimeInQueue())
                / _model.Drain.DrainedTransacts.Count).ToString();
            avgTimeInServerLbl.Text = (_model.Drain.DrainedTransacts.Sum(t => t.GetTimeInServer())
                / _model.Drain.DrainedTransacts.Count).ToString();
            withoutQueueLbl.Text = ((double)_model.Drain.DrainedTransacts.Where(t => t.GetTimeInQueue() == 0).Count()
                / _model.Drain.DrainedTransacts.Count * 100).ToString() + "%";

            double prevTime = 0;
            double freeTime = 0;
            var serverLogs = logs.Where(l => l.Event == EventTypeEnum.EnterServer || l.Event == EventTypeEnum.LeaveServer);
            foreach (var log in serverLogs)
            {
                if (log.Event == EventTypeEnum.EnterServer)
                    freeTime = log.Time - prevTime;
                if (log.Event == EventTypeEnum.LeaveServer)
                    prevTime = log.Time;
            }
            freeTimeCoefLbl.Text = (freeTime / modelTime).ToString();

            abChart.Series.FirstOrDefault().Points.Clear();
            abChart.Series.FirstOrDefault().IsValueShownAsLabel = false;
            int aCount = _model.Drain.DrainedTransacts.Where(t => t.Type == TransactTypeEnum.Atype).Count(),
                bCount = _model.Drain.DrainedTransacts.Where(t => t.Type == TransactTypeEnum.Btype).Count();
            abChart.Series.FirstOrDefault().Points.Add(new DataPoint()
            {
                Name = "A",
                LegendText = "A " + ((double)aCount / _model.Drain.DrainedTransacts.Count).ToString("0.###") + " %",
                XValue = aCount,
                Label = "A",
                YValues = new double[] { aCount }
            });
            abChart.Series.FirstOrDefault().Points.Add(new DataPoint()
            {
                Name = "B",
                LegendText = "B " + ((double)bCount / _model.Drain.DrainedTransacts.Count).ToString("0.###") + " %",
                XValue = bCount,
                Label = "B",
                YValues = new double[] { bCount }
            });

            exportBtn.Enabled = true;
        }


        private void transactsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tran = transactsBox.SelectedItem as Transact;
            transactStoryBox.DataSource = tran.GetJournal();

            trLifeTimeLbl.Text = tran.GetLifeTime().ToString();
            trWaitLbl.Text = tran.GetTimeInQueue().ToString();
            trServerTimeLbl.Text = tran.GetTimeInServer().ToString();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            exportBtn.Enabled = false;

            string fileName = "ModelLogs.txt";
            var list = (modelLogsBox.DataSource as IEnumerable<ModelLog>).ToList();
            var fs = File.Create(fileName);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (ModelLog log in list)
                    sw.WriteLine(log.ToString());
            }
            fs.Close();
            Process.Start(fileName);

            exportBtn.Enabled = true;
        }
    }
}