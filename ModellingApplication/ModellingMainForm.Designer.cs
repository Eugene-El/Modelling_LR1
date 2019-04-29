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
            this.modelBtn = new System.Windows.Forms.Button();
            this.transactsBox = new System.Windows.Forms.ListBox();
            this.transactStoryBox = new System.Windows.Forms.ListBox();
            this.modelLogsBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transactInfoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trLifeTimeLbl = new System.Windows.Forms.Label();
            this.trWaitLbl = new System.Windows.Forms.Label();
            this.trServerTimeLbl = new System.Windows.Forms.Label();
            this.transactInfoBox.SuspendLayout();
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
            this.transactStoryBox.Size = new System.Drawing.Size(285, 82);
            this.transactStoryBox.TabIndex = 2;
            // 
            // modelLogsBox
            // 
            this.modelLogsBox.FormattingEnabled = true;
            this.modelLogsBox.Location = new System.Drawing.Point(492, 16);
            this.modelLogsBox.Name = "modelLogsBox";
            this.modelLogsBox.Size = new System.Drawing.Size(441, 420);
            this.modelLogsBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(201, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model statistic";
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
            this.transactInfoBox.Size = new System.Drawing.Size(285, 70);
            this.transactInfoBox.TabIndex = 5;
            this.transactInfoBox.TabStop = false;
            this.transactInfoBox.Text = "Transact Info";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting in queue:";
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
            // trLifeTimeLbl
            // 
            this.trLifeTimeLbl.AutoSize = true;
            this.trLifeTimeLbl.Location = new System.Drawing.Point(121, 20);
            this.trLifeTimeLbl.Name = "trLifeTimeLbl";
            this.trLifeTimeLbl.Size = new System.Drawing.Size(14, 13);
            this.trLifeTimeLbl.TabIndex = 3;
            this.trLifeTimeLbl.Text = "0";
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
            // trServerTimeLbl
            // 
            this.trServerTimeLbl.AutoSize = true;
            this.trServerTimeLbl.Location = new System.Drawing.Point(121, 46);
            this.trServerTimeLbl.Name = "trServerTimeLbl";
            this.trServerTimeLbl.Size = new System.Drawing.Size(14, 13);
            this.trServerTimeLbl.TabIndex = 5;
            this.trServerTimeLbl.Text = "0";
            // 
            // ModellingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(939, 451);
            this.Controls.Add(this.transactInfoBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modelLogsBox);
            this.Controls.Add(this.transactStoryBox);
            this.Controls.Add(this.transactsBox);
            this.Controls.Add(this.modelBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ModellingMainForm";
            this.Text = "Modelling application";
            this.transactInfoBox.ResumeLayout(false);
            this.transactInfoBox.PerformLayout();
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
    }
}

