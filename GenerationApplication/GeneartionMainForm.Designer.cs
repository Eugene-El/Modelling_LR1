namespace GenerationApplication
{
    partial class GeneartionMainForm
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
            this.histogramPicBox = new System.Windows.Forms.PictureBox();
            this.configurationBox = new System.Windows.Forms.GroupBox();
            this.seedBox = new System.Windows.Forms.GroupBox();
            this.seedNumeric = new System.Windows.Forms.NumericUpDown();
            this.useRandomSeedCheck = new System.Windows.Forms.CheckBox();
            this.elementsCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.elementsCountLbl = new System.Windows.Forms.Label();
            this.groupCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupCountLbl = new System.Windows.Forms.Label();
            this.distributionLbl = new System.Windows.Forms.Label();
            this.distributionCmb = new System.Windows.Forms.ComboBox();
            this.heightNumeric = new System.Windows.Forms.NumericUpDown();
            this.heightLbl = new System.Windows.Forms.Label();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.widthLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.numberPageList = new GenerationApplication.NumberPageList();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPicBox)).BeginInit();
            this.configurationBox.SuspendLayout();
            this.seedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramPicBox
            // 
            this.histogramPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramPicBox.Location = new System.Drawing.Point(14, 13);
            this.histogramPicBox.Name = "histogramPicBox";
            this.histogramPicBox.Size = new System.Drawing.Size(316, 259);
            this.histogramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramPicBox.TabIndex = 0;
            this.histogramPicBox.TabStop = false;
            // 
            // configurationBox
            // 
            this.configurationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationBox.Controls.Add(this.seedBox);
            this.configurationBox.Controls.Add(this.elementsCountNumeric);
            this.configurationBox.Controls.Add(this.elementsCountLbl);
            this.configurationBox.Controls.Add(this.groupCountNumeric);
            this.configurationBox.Controls.Add(this.groupCountLbl);
            this.configurationBox.Controls.Add(this.distributionLbl);
            this.configurationBox.Controls.Add(this.distributionCmb);
            this.configurationBox.Controls.Add(this.heightNumeric);
            this.configurationBox.Controls.Add(this.heightLbl);
            this.configurationBox.Controls.Add(this.widthNumeric);
            this.configurationBox.Controls.Add(this.widthLbl);
            this.configurationBox.Location = new System.Drawing.Point(336, 13);
            this.configurationBox.Name = "configurationBox";
            this.configurationBox.Size = new System.Drawing.Size(236, 437);
            this.configurationBox.TabIndex = 1;
            this.configurationBox.TabStop = false;
            this.configurationBox.Text = "Configuration";
            // 
            // seedBox
            // 
            this.seedBox.Controls.Add(this.seedNumeric);
            this.seedBox.Controls.Add(this.useRandomSeedCheck);
            this.seedBox.Location = new System.Drawing.Point(12, 152);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(214, 72);
            this.seedBox.TabIndex = 10;
            this.seedBox.TabStop = false;
            this.seedBox.Text = "Seed";
            // 
            // seedNumeric
            // 
            this.seedNumeric.BackColor = System.Drawing.Color.SaddleBrown;
            this.seedNumeric.Location = new System.Drawing.Point(6, 43);
            this.seedNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seedNumeric.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.seedNumeric.Name = "seedNumeric";
            this.seedNumeric.Size = new System.Drawing.Size(202, 20);
            this.seedNumeric.TabIndex = 12;
            this.seedNumeric.Visible = false;
            // 
            // useRandomSeedCheck
            // 
            this.useRandomSeedCheck.AutoSize = true;
            this.useRandomSeedCheck.Checked = true;
            this.useRandomSeedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useRandomSeedCheck.Location = new System.Drawing.Point(6, 19);
            this.useRandomSeedCheck.Name = "useRandomSeedCheck";
            this.useRandomSeedCheck.Size = new System.Drawing.Size(124, 18);
            this.useRandomSeedCheck.TabIndex = 11;
            this.useRandomSeedCheck.Text = "Use random seed";
            this.useRandomSeedCheck.UseVisualStyleBackColor = true;
            this.useRandomSeedCheck.CheckedChanged += new System.EventHandler(this.useRandomSeedCheck_CheckedChanged);
            // 
            // elementsCountNumeric
            // 
            this.elementsCountNumeric.BackColor = System.Drawing.Color.SaddleBrown;
            this.elementsCountNumeric.Location = new System.Drawing.Point(111, 126);
            this.elementsCountNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.elementsCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elementsCountNumeric.Name = "elementsCountNumeric";
            this.elementsCountNumeric.Size = new System.Drawing.Size(115, 20);
            this.elementsCountNumeric.TabIndex = 9;
            this.elementsCountNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // elementsCountLbl
            // 
            this.elementsCountLbl.AutoSize = true;
            this.elementsCountLbl.Location = new System.Drawing.Point(9, 128);
            this.elementsCountLbl.Name = "elementsCountLbl";
            this.elementsCountLbl.Size = new System.Drawing.Size(96, 14);
            this.elementsCountLbl.TabIndex = 8;
            this.elementsCountLbl.Text = "Elements count:";
            // 
            // groupCountNumeric
            // 
            this.groupCountNumeric.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupCountNumeric.Location = new System.Drawing.Point(93, 100);
            this.groupCountNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.groupCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groupCountNumeric.Name = "groupCountNumeric";
            this.groupCountNumeric.Size = new System.Drawing.Size(133, 20);
            this.groupCountNumeric.TabIndex = 7;
            this.groupCountNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupCountLbl
            // 
            this.groupCountLbl.AutoSize = true;
            this.groupCountLbl.Location = new System.Drawing.Point(9, 102);
            this.groupCountLbl.Name = "groupCountLbl";
            this.groupCountLbl.Size = new System.Drawing.Size(78, 14);
            this.groupCountLbl.TabIndex = 6;
            this.groupCountLbl.Text = "Group count:";
            // 
            // distributionLbl
            // 
            this.distributionLbl.AutoSize = true;
            this.distributionLbl.Location = new System.Drawing.Point(9, 75);
            this.distributionLbl.Name = "distributionLbl";
            this.distributionLbl.Size = new System.Drawing.Size(69, 14);
            this.distributionLbl.TabIndex = 5;
            this.distributionLbl.Text = "Distibution:";
            // 
            // distributionCmb
            // 
            this.distributionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distributionCmb.FormattingEnabled = true;
            this.distributionCmb.Items.AddRange(new object[] {
            "Uniform",
            "Exponential",
            "Erlang"});
            this.distributionCmb.Location = new System.Drawing.Point(84, 72);
            this.distributionCmb.Name = "distributionCmb";
            this.distributionCmb.Size = new System.Drawing.Size(142, 22);
            this.distributionCmb.TabIndex = 4;
            // 
            // heightNumeric
            // 
            this.heightNumeric.BackColor = System.Drawing.Color.SaddleBrown;
            this.heightNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.heightNumeric.Location = new System.Drawing.Point(60, 46);
            this.heightNumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.heightNumeric.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.heightNumeric.Name = "heightNumeric";
            this.heightNumeric.Size = new System.Drawing.Size(166, 20);
            this.heightNumeric.TabIndex = 3;
            this.heightNumeric.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(9, 48);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(45, 14);
            this.heightLbl.TabIndex = 2;
            this.heightLbl.Text = "Height:";
            // 
            // widthNumeric
            // 
            this.widthNumeric.BackColor = System.Drawing.Color.SaddleBrown;
            this.widthNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.widthNumeric.Location = new System.Drawing.Point(60, 20);
            this.widthNumeric.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.widthNumeric.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.widthNumeric.Name = "widthNumeric";
            this.widthNumeric.Size = new System.Drawing.Size(166, 20);
            this.widthNumeric.TabIndex = 1;
            this.widthNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(9, 22);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(41, 14);
            this.widthLbl.TabIndex = 0;
            this.widthLbl.Text = "Width:";
            // 
            // generateBtn
            // 
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generateBtn.Location = new System.Drawing.Point(235, 278);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(95, 172);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // numberPageList
            // 
            this.numberPageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberPageList.Location = new System.Drawing.Point(12, 278);
            this.numberPageList.Name = "numberPageList";
            this.numberPageList.NumberList = null;
            this.numberPageList.PageSize = 10;
            this.numberPageList.Size = new System.Drawing.Size(217, 172);
            this.numberPageList.TabIndex = 4;
            // 
            // GeneartionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.numberPageList);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.configurationBox);
            this.Controls.Add(this.histogramPicBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Name = "GeneartionMainForm";
            this.Text = "Generation application";
            ((System.ComponentModel.ISupportInitialize)(this.histogramPicBox)).EndInit();
            this.configurationBox.ResumeLayout(false);
            this.configurationBox.PerformLayout();
            this.seedBox.ResumeLayout(false);
            this.seedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox histogramPicBox;
        private System.Windows.Forms.GroupBox configurationBox;
        private System.Windows.Forms.NumericUpDown heightNumeric;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label distributionLbl;
        private System.Windows.Forms.ComboBox distributionCmb;
        private System.Windows.Forms.Label groupCountLbl;
        private System.Windows.Forms.NumericUpDown elementsCountNumeric;
        private System.Windows.Forms.Label elementsCountLbl;
        private System.Windows.Forms.NumericUpDown groupCountNumeric;
        private System.Windows.Forms.GroupBox seedBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.CheckBox useRandomSeedCheck;
        private System.Windows.Forms.NumericUpDown seedNumeric;
        private NumberPageList numberPageList;
    }
}

