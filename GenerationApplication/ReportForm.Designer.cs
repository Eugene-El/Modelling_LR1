namespace GenerationApplication
{
    partial class ReportForm
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
            this.mainStatBox = new System.Windows.Forms.GroupBox();
            this.stdDevLbl = new System.Windows.Forms.Label();
            this.meanLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.nLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testConfBox = new System.Windows.Forms.GroupBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.alphaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.GroupBox();
            this.ksWithoutLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ksLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.opgLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exStdDevLbl = new System.Windows.Forms.Label();
            this.exMeanLbl = new System.Windows.Forms.Label();
            this.exMaxLbl = new System.Windows.Forms.Label();
            this.exMinLbl = new System.Windows.Forms.Label();
            this.exNLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.exStatNumPg = new GenerationApplication.NumberPageList();
            this.mainStatNumPg = new GenerationApplication.NumberPageList();
            this.mainStatBox.SuspendLayout();
            this.testConfBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).BeginInit();
            this.checkBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatBox
            // 
            this.mainStatBox.Controls.Add(this.stdDevLbl);
            this.mainStatBox.Controls.Add(this.meanLbl);
            this.mainStatBox.Controls.Add(this.maxLbl);
            this.mainStatBox.Controls.Add(this.minLbl);
            this.mainStatBox.Controls.Add(this.nLbl);
            this.mainStatBox.Controls.Add(this.label5);
            this.mainStatBox.Controls.Add(this.label4);
            this.mainStatBox.Controls.Add(this.label3);
            this.mainStatBox.Controls.Add(this.label2);
            this.mainStatBox.Controls.Add(this.label1);
            this.mainStatBox.Location = new System.Drawing.Point(14, 12);
            this.mainStatBox.Name = "mainStatBox";
            this.mainStatBox.Size = new System.Drawing.Size(256, 87);
            this.mainStatBox.TabIndex = 0;
            this.mainStatBox.TabStop = false;
            this.mainStatBox.Text = "Main statistic";
            // 
            // stdDevLbl
            // 
            this.stdDevLbl.AutoSize = true;
            this.stdDevLbl.Location = new System.Drawing.Point(105, 68);
            this.stdDevLbl.Name = "stdDevLbl";
            this.stdDevLbl.Size = new System.Drawing.Size(14, 13);
            this.stdDevLbl.TabIndex = 9;
            this.stdDevLbl.Text = "0";
            // 
            // meanLbl
            // 
            this.meanLbl.AutoSize = true;
            this.meanLbl.Location = new System.Drawing.Point(105, 55);
            this.meanLbl.Name = "meanLbl";
            this.meanLbl.Size = new System.Drawing.Size(14, 13);
            this.meanLbl.TabIndex = 8;
            this.meanLbl.Text = "0";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(105, 42);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(14, 13);
            this.maxLbl.TabIndex = 7;
            this.maxLbl.Text = "0";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(105, 29);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(14, 13);
            this.minLbl.TabIndex = 6;
            this.minLbl.Text = "0";
            // 
            // nLbl
            // 
            this.nLbl.AutoSize = true;
            this.nLbl.Location = new System.Drawing.Point(105, 16);
            this.nLbl.Name = "nLbl";
            this.nLbl.Size = new System.Drawing.Size(14, 13);
            this.nLbl.TabIndex = 5;
            this.nLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Std. Dev.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mean:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // testConfBox
            // 
            this.testConfBox.Controls.Add(this.testBtn);
            this.testConfBox.Controls.Add(this.alphaNumeric);
            this.testConfBox.Controls.Add(this.label6);
            this.testConfBox.Location = new System.Drawing.Point(368, 319);
            this.testConfBox.Name = "testConfBox";
            this.testConfBox.Size = new System.Drawing.Size(164, 86);
            this.testConfBox.TabIndex = 4;
            this.testConfBox.TabStop = false;
            this.testConfBox.Text = "Test configuration";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(12, 45);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(146, 36);
            this.testBtn.TabIndex = 6;
            this.testBtn.Text = "Generate and test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // alphaNumeric
            // 
            this.alphaNumeric.DecimalPlaces = 4;
            this.alphaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphaNumeric.Location = new System.Drawing.Point(45, 19);
            this.alphaNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alphaNumeric.Name = "alphaNumeric";
            this.alphaNumeric.Size = new System.Drawing.Size(113, 20);
            this.alphaNumeric.TabIndex = 5;
            this.alphaNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "α = ";
            // 
            // checkBox
            // 
            this.checkBox.Controls.Add(this.ksWithoutLbl);
            this.checkBox.Controls.Add(this.label10);
            this.checkBox.Controls.Add(this.ksLbl);
            this.checkBox.Controls.Add(this.label8);
            this.checkBox.Controls.Add(this.opgLbl);
            this.checkBox.Controls.Add(this.label7);
            this.checkBox.Location = new System.Drawing.Point(14, 319);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(348, 86);
            this.checkBox.TabIndex = 5;
            this.checkBox.TabStop = false;
            this.checkBox.Text = "Check";
            // 
            // ksWithoutLbl
            // 
            this.ksWithoutLbl.AutoSize = true;
            this.ksWithoutLbl.Location = new System.Drawing.Point(185, 57);
            this.ksWithoutLbl.Name = "ksWithoutLbl";
            this.ksWithoutLbl.Size = new System.Drawing.Size(14, 13);
            this.ksWithoutLbl.TabIndex = 5;
            this.ksWithoutLbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "KS without correction:";
            // 
            // ksLbl
            // 
            this.ksLbl.AutoSize = true;
            this.ksLbl.Location = new System.Drawing.Point(185, 39);
            this.ksLbl.Name = "ksLbl";
            this.ksLbl.Size = new System.Drawing.Size(14, 13);
            this.ksLbl.TabIndex = 3;
            this.ksLbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kolmogorov Smirnov:";
            // 
            // opgLbl
            // 
            this.opgLbl.AutoSize = true;
            this.opgLbl.Location = new System.Drawing.Point(185, 20);
            this.opgLbl.Name = "opgLbl";
            this.opgLbl.Size = new System.Drawing.Size(37, 13);
            this.opgLbl.TabIndex = 1;
            this.opgLbl.Text = "(0; 0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hypothesis acceptance area:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exStdDevLbl);
            this.groupBox2.Controls.Add(this.exMeanLbl);
            this.groupBox2.Controls.Add(this.exMaxLbl);
            this.groupBox2.Controls.Add(this.exMinLbl);
            this.groupBox2.Controls.Add(this.exNLbl);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 87);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated by library statistic";
            // 
            // exStdDevLbl
            // 
            this.exStdDevLbl.AutoSize = true;
            this.exStdDevLbl.Location = new System.Drawing.Point(105, 68);
            this.exStdDevLbl.Name = "exStdDevLbl";
            this.exStdDevLbl.Size = new System.Drawing.Size(14, 13);
            this.exStdDevLbl.TabIndex = 9;
            this.exStdDevLbl.Text = "0";
            // 
            // exMeanLbl
            // 
            this.exMeanLbl.AutoSize = true;
            this.exMeanLbl.Location = new System.Drawing.Point(105, 55);
            this.exMeanLbl.Name = "exMeanLbl";
            this.exMeanLbl.Size = new System.Drawing.Size(14, 13);
            this.exMeanLbl.TabIndex = 8;
            this.exMeanLbl.Text = "0";
            // 
            // exMaxLbl
            // 
            this.exMaxLbl.AutoSize = true;
            this.exMaxLbl.Location = new System.Drawing.Point(105, 42);
            this.exMaxLbl.Name = "exMaxLbl";
            this.exMaxLbl.Size = new System.Drawing.Size(14, 13);
            this.exMaxLbl.TabIndex = 7;
            this.exMaxLbl.Text = "0";
            // 
            // exMinLbl
            // 
            this.exMinLbl.AutoSize = true;
            this.exMinLbl.Location = new System.Drawing.Point(105, 29);
            this.exMinLbl.Name = "exMinLbl";
            this.exMinLbl.Size = new System.Drawing.Size(14, 13);
            this.exMinLbl.TabIndex = 6;
            this.exMinLbl.Text = "0";
            // 
            // exNLbl
            // 
            this.exNLbl.AutoSize = true;
            this.exNLbl.Location = new System.Drawing.Point(105, 16);
            this.exNLbl.Name = "exNLbl";
            this.exNLbl.Size = new System.Drawing.Size(14, 13);
            this.exNLbl.TabIndex = 5;
            this.exNLbl.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Std. Dev.:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Mean:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Max:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Min:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "N:";
            // 
            // exStatNumPg
            // 
            this.exStatNumPg.Location = new System.Drawing.Point(276, 105);
            this.exStatNumPg.Name = "exStatNumPg";
            this.exStatNumPg.NumberList = null;
            this.exStatNumPg.Size = new System.Drawing.Size(256, 208);
            this.exStatNumPg.TabIndex = 8;
            // 
            // mainStatNumPg
            // 
            this.mainStatNumPg.Location = new System.Drawing.Point(14, 105);
            this.mainStatNumPg.Name = "mainStatNumPg";
            this.mainStatNumPg.NumberList = null;
            this.mainStatNumPg.Size = new System.Drawing.Size(256, 208);
            this.mainStatNumPg.TabIndex = 7;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(542, 414);
            this.Controls.Add(this.exStatNumPg);
            this.Controls.Add(this.mainStatNumPg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.testConfBox);
            this.Controls.Add(this.mainStatBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.mainStatBox.ResumeLayout(false);
            this.mainStatBox.PerformLayout();
            this.testConfBox.ResumeLayout(false);
            this.testConfBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).EndInit();
            this.checkBox.ResumeLayout(false);
            this.checkBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainStatBox;
        private System.Windows.Forms.Label stdDevLbl;
        private System.Windows.Forms.Label meanLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label nLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox testConfBox;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.NumericUpDown alphaNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox checkBox;
        private System.Windows.Forms.Label opgLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ksLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label exStdDevLbl;
        private System.Windows.Forms.Label exMeanLbl;
        private System.Windows.Forms.Label exMaxLbl;
        private System.Windows.Forms.Label exMinLbl;
        private System.Windows.Forms.Label exNLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private NumberPageList mainStatNumPg;
        private NumberPageList exStatNumPg;
        private System.Windows.Forms.Label ksWithoutLbl;
        private System.Windows.Forms.Label label10;
    }
}