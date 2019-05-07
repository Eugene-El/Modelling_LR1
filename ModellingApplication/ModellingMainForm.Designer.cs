namespace ModellingApplication
{
    partial class ModellingMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.modelBtn = new System.Windows.Forms.Button();
            this.transactsBox = new System.Windows.Forms.ListBox();
            this.transactStoryBox = new System.Windows.Forms.ListBox();
            this.modelLogsBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.avgLifeTimeLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.avgTimeInServerLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.freeTimeCoefLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.withoutQueueLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avgTimeInQueueLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transactCountLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transactInfoBox = new System.Windows.Forms.GroupBox();
            this.trServerTimeLbl = new System.Windows.Forms.Label();
            this.trWaitLbl = new System.Windows.Forms.Label();
            this.trLifeTimeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.abChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.transactInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abChart)).BeginInit();
            this.SuspendLayout();
            // 
            // modelBtn
            // 
            this.modelBtn.Location = new System.Drawing.Point(13, 13);
            this.modelBtn.Name = "modelBtn";
            this.modelBtn.Size = new System.Drawing.Size(182, 49);
            this.modelBtn.TabIndex = 0;
            this.modelBtn.Text = "Model";
            this.modelBtn.UseVisualStyleBackColor = true;
            this.modelBtn.Click += new System.EventHandler(this.modelBtn_Click);
            // 
            // transactsBox
            // 
            this.transactsBox.FormattingEnabled = true;
            this.transactsBox.Location = new System.Drawing.Point(13, 68);
            this.transactsBox.Name = "transactsBox";
            this.transactsBox.Size = new System.Drawing.Size(182, 368);
            this.transactsBox.TabIndex = 1;
            this.transactsBox.SelectedIndexChanged += new System.EventHandler(this.transactsBox_SelectedIndexChanged);
            // 
            // transactStoryBox
            // 
            this.transactStoryBox.FormattingEnabled = true;
            this.transactStoryBox.Location = new System.Drawing.Point(201, 354);
            this.transactStoryBox.Name = "transactStoryBox";
            this.transactStoryBox.Size = new System.Drawing.Size(324, 82);
            this.transactStoryBox.TabIndex = 2;
            // 
            // modelLogsBox
            // 
            this.modelLogsBox.FormattingEnabled = true;
            this.modelLogsBox.Location = new System.Drawing.Point(531, 16);
            this.modelLogsBox.Name = "modelLogsBox";
            this.modelLogsBox.Size = new System.Drawing.Size(441, 381);
            this.modelLogsBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.avgLifeTimeLbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.avgTimeInServerLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.freeTimeCoefLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.withoutQueueLbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.avgTimeInQueueLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.transactCountLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(201, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model statistic";
            // 
            // avgLifeTimeLbl
            // 
            this.avgLifeTimeLbl.AutoSize = true;
            this.avgLifeTimeLbl.Location = new System.Drawing.Point(169, 39);
            this.avgLifeTimeLbl.Name = "avgLifeTimeLbl";
            this.avgLifeTimeLbl.Size = new System.Drawing.Size(14, 13);
            this.avgLifeTimeLbl.TabIndex = 13;
            this.avgLifeTimeLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Average life time:";
            // 
            // avgTimeInServerLbl
            // 
            this.avgTimeInServerLbl.AutoSize = true;
            this.avgTimeInServerLbl.Location = new System.Drawing.Point(169, 65);
            this.avgTimeInServerLbl.Name = "avgTimeInServerLbl";
            this.avgTimeInServerLbl.Size = new System.Drawing.Size(14, 13);
            this.avgTimeInServerLbl.TabIndex = 11;
            this.avgTimeInServerLbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Average time in server:";
            // 
            // freeTimeCoefLbl
            // 
            this.freeTimeCoefLbl.AutoSize = true;
            this.freeTimeCoefLbl.Location = new System.Drawing.Point(168, 109);
            this.freeTimeCoefLbl.Name = "freeTimeCoefLbl";
            this.freeTimeCoefLbl.Size = new System.Drawing.Size(14, 13);
            this.freeTimeCoefLbl.TabIndex = 7;
            this.freeTimeCoefLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Server free time coefficient:";
            // 
            // withoutQueueLbl
            // 
            this.withoutQueueLbl.AutoSize = true;
            this.withoutQueueLbl.Location = new System.Drawing.Point(168, 96);
            this.withoutQueueLbl.Name = "withoutQueueLbl";
            this.withoutQueueLbl.Size = new System.Drawing.Size(14, 13);
            this.withoutQueueLbl.TabIndex = 5;
            this.withoutQueueLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Get server without queue:";
            // 
            // avgTimeInQueueLbl
            // 
            this.avgTimeInQueueLbl.AutoSize = true;
            this.avgTimeInQueueLbl.Location = new System.Drawing.Point(169, 52);
            this.avgTimeInQueueLbl.Name = "avgTimeInQueueLbl";
            this.avgTimeInQueueLbl.Size = new System.Drawing.Size(14, 13);
            this.avgTimeInQueueLbl.TabIndex = 3;
            this.avgTimeInQueueLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average time in queue:";
            // 
            // transactCountLbl
            // 
            this.transactCountLbl.AutoSize = true;
            this.transactCountLbl.Location = new System.Drawing.Point(169, 15);
            this.transactCountLbl.Name = "transactCountLbl";
            this.transactCountLbl.Size = new System.Drawing.Size(14, 13);
            this.transactCountLbl.TabIndex = 1;
            this.transactCountLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Transact count:";
            // 
            // transactInfoBox
            // 
            this.transactInfoBox.Controls.Add(this.trServerTimeLbl);
            this.transactInfoBox.Controls.Add(this.trWaitLbl);
            this.transactInfoBox.Controls.Add(this.trLifeTimeLbl);
            this.transactInfoBox.Controls.Add(this.label3);
            this.transactInfoBox.Controls.Add(this.label2);
            this.transactInfoBox.Controls.Add(this.label1);
            this.transactInfoBox.Location = new System.Drawing.Point(201, 278);
            this.transactInfoBox.Name = "transactInfoBox";
            this.transactInfoBox.Size = new System.Drawing.Size(324, 70);
            this.transactInfoBox.TabIndex = 5;
            this.transactInfoBox.TabStop = false;
            this.transactInfoBox.Text = "Transact Info";
            // 
            // trServerTimeLbl
            // 
            this.trServerTimeLbl.AutoSize = true;
            this.trServerTimeLbl.Location = new System.Drawing.Point(121, 46);
            this.trServerTimeLbl.Name = "trServerTimeLbl";
            this.trServerTimeLbl.Size = new System.Drawing.Size(14, 13);
            this.trServerTimeLbl.TabIndex = 5;
            this.trServerTimeLbl.Text = "0";
            // 
            // trWaitLbl
            // 
            this.trWaitLbl.AutoSize = true;
            this.trWaitLbl.Location = new System.Drawing.Point(121, 33);
            this.trWaitLbl.Name = "trWaitLbl";
            this.trWaitLbl.Size = new System.Drawing.Size(14, 13);
            this.trWaitLbl.TabIndex = 4;
            this.trWaitLbl.Text = "0";
            // 
            // trLifeTimeLbl
            // 
            this.trLifeTimeLbl.AutoSize = true;
            this.trLifeTimeLbl.Location = new System.Drawing.Point(121, 20);
            this.trLifeTimeLbl.Name = "trLifeTimeLbl";
            this.trLifeTimeLbl.Size = new System.Drawing.Size(14, 13);
            this.trLifeTimeLbl.TabIndex = 3;
            this.trLifeTimeLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time in server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting in queue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Life time:";
            // 
            // abChart
            // 
            chartArea2.Name = "ChartArea1";
            this.abChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.abChart.Legends.Add(legend2);
            this.abChart.Location = new System.Drawing.Point(201, 154);
            this.abChart.Name = "abChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.abChart.Series.Add(series2);
            this.abChart.Size = new System.Drawing.Size(324, 118);
            this.abChart.TabIndex = 6;
            this.abChart.Text = "chart1";
            // 
            // exportBtn
            // 
            this.exportBtn.Enabled = false;
            this.exportBtn.Location = new System.Drawing.Point(532, 404);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(440, 32);
            this.exportBtn.TabIndex = 7;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // ModellingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.abChart);
            this.Controls.Add(this.transactInfoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modelLogsBox);
            this.Controls.Add(this.transactStoryBox);
            this.Controls.Add(this.transactsBox);
            this.Controls.Add(this.modelBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModellingMainForm";
            this.Text = "Modelling application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.transactInfoBox.ResumeLayout(false);
            this.transactInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modelBtn;
        private System.Windows.Forms.ListBox transactsBox;
        private System.Windows.Forms.ListBox transactStoryBox;
        private System.Windows.Forms.ListBox modelLogsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox transactInfoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label trServerTimeLbl;
        private System.Windows.Forms.Label trWaitLbl;
        private System.Windows.Forms.Label trLifeTimeLbl;
        private System.Windows.Forms.Label transactCountLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label avgTimeInQueueLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label withoutQueueLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label freeTimeCoefLbl;
        private System.Windows.Forms.Label avgLifeTimeLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label avgTimeInServerLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart abChart;
        private System.Windows.Forms.Button exportBtn;
    }
}

