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
            this.distributionTabControl = new System.Windows.Forms.TabControl();
            this.uniformTab = new System.Windows.Forms.TabPage();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.bLbl = new System.Windows.Forms.Label();
            this.aNumeric = new System.Windows.Forms.NumericUpDown();
            this.aLbl = new System.Windows.Forms.Label();
            this.exponentialTab = new System.Windows.Forms.TabPage();
            this.lambdaNumeric = new System.Windows.Forms.NumericUpDown();
            this.lambdaLbl = new System.Windows.Forms.Label();
            this.erlangTab = new System.Windows.Forms.TabPage();
            this.nNumeric = new System.Windows.Forms.NumericUpDown();
            this.nLbl = new System.Windows.Forms.Label();
            this.lambdaErlangNumeric = new System.Windows.Forms.NumericUpDown();
            this.lambdaLbl2 = new System.Windows.Forms.Label();
            this.normalTab = new System.Windows.Forms.TabPage();
            this.sigmaNumeric = new System.Windows.Forms.NumericUpDown();
            this.sigmaLbl = new System.Windows.Forms.Label();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.mLbl = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.GroupBox();
            this.seedNumeric = new System.Windows.Forms.NumericUpDown();
            this.useRandomSeedCheck = new System.Windows.Forms.CheckBox();
            this.elementsCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.elementsCountLbl = new System.Windows.Forms.Label();
            this.groupCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupCountLbl = new System.Windows.Forms.Label();
            this.heightNumeric = new System.Windows.Forms.NumericUpDown();
            this.heightLbl = new System.Windows.Forms.Label();
            this.widthNumeric = new System.Windows.Forms.NumericUpDown();
            this.widthLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.numberPageList = new GenerationApplication.NumberPageList();
            this.poissonTab = new System.Windows.Forms.TabPage();
            this.poissonLambdaNumeric = new System.Windows.Forms.NumericUpDown();
            this.poissonLambdaLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPicBox)).BeginInit();
            this.configurationBox.SuspendLayout();
            this.distributionTabControl.SuspendLayout();
            this.uniformTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumeric)).BeginInit();
            this.exponentialTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumeric)).BeginInit();
            this.erlangTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaErlangNumeric)).BeginInit();
            this.normalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            this.seedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).BeginInit();
            this.poissonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poissonLambdaNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramPicBox
            // 
            this.histogramPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramPicBox.Location = new System.Drawing.Point(14, 13);
            this.histogramPicBox.Name = "histogramPicBox";
            this.histogramPicBox.Size = new System.Drawing.Size(516, 536);
            this.histogramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramPicBox.TabIndex = 0;
            this.histogramPicBox.TabStop = false;
            // 
            // configurationBox
            // 
            this.configurationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationBox.Controls.Add(this.distributionTabControl);
            this.configurationBox.Controls.Add(this.seedBox);
            this.configurationBox.Controls.Add(this.elementsCountNumeric);
            this.configurationBox.Controls.Add(this.elementsCountLbl);
            this.configurationBox.Controls.Add(this.groupCountNumeric);
            this.configurationBox.Controls.Add(this.groupCountLbl);
            this.configurationBox.Controls.Add(this.heightNumeric);
            this.configurationBox.Controls.Add(this.heightLbl);
            this.configurationBox.Controls.Add(this.widthNumeric);
            this.configurationBox.Controls.Add(this.widthLbl);
            this.configurationBox.Location = new System.Drawing.Point(536, 13);
            this.configurationBox.Name = "configurationBox";
            this.configurationBox.Size = new System.Drawing.Size(236, 314);
            this.configurationBox.TabIndex = 1;
            this.configurationBox.TabStop = false;
            this.configurationBox.Text = "Configuration";
            this.configurationBox.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxesPaint);
            // 
            // distributionTabControl
            // 
            this.distributionTabControl.Controls.Add(this.uniformTab);
            this.distributionTabControl.Controls.Add(this.exponentialTab);
            this.distributionTabControl.Controls.Add(this.erlangTab);
            this.distributionTabControl.Controls.Add(this.normalTab);
            this.distributionTabControl.Controls.Add(this.poissonTab);
            this.distributionTabControl.Location = new System.Drawing.Point(8, 202);
            this.distributionTabControl.Multiline = true;
            this.distributionTabControl.Name = "distributionTabControl";
            this.distributionTabControl.SelectedIndex = 0;
            this.distributionTabControl.Size = new System.Drawing.Size(222, 104);
            this.distributionTabControl.TabIndex = 11;
            // 
            // uniformTab
            // 
            this.uniformTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.uniformTab.Controls.Add(this.bNumeric);
            this.uniformTab.Controls.Add(this.bLbl);
            this.uniformTab.Controls.Add(this.aNumeric);
            this.uniformTab.Controls.Add(this.aLbl);
            this.uniformTab.Location = new System.Drawing.Point(4, 42);
            this.uniformTab.Name = "uniformTab";
            this.uniformTab.Padding = new System.Windows.Forms.Padding(3);
            this.uniformTab.Size = new System.Drawing.Size(214, 58);
            this.uniformTab.TabIndex = 0;
            this.uniformTab.Text = "Uniform";
            // 
            // bNumeric
            // 
            this.bNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bNumeric.DecimalPlaces = 3;
            this.bNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.bNumeric.Location = new System.Drawing.Point(30, 32);
            this.bNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.bNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(178, 20);
            this.bNumeric.TabIndex = 7;
            this.bNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Location = new System.Drawing.Point(8, 34);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(17, 14);
            this.bLbl.TabIndex = 6;
            this.bLbl.Text = "b:";
            // 
            // aNumeric
            // 
            this.aNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aNumeric.DecimalPlaces = 3;
            this.aNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.aNumeric.Location = new System.Drawing.Point(30, 6);
            this.aNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.aNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.aNumeric.Name = "aNumeric";
            this.aNumeric.Size = new System.Drawing.Size(178, 20);
            this.aNumeric.TabIndex = 5;
            // 
            // aLbl
            // 
            this.aLbl.AutoSize = true;
            this.aLbl.Location = new System.Drawing.Point(8, 8);
            this.aLbl.Name = "aLbl";
            this.aLbl.Size = new System.Drawing.Size(16, 14);
            this.aLbl.TabIndex = 4;
            this.aLbl.Text = "a:";
            // 
            // exponentialTab
            // 
            this.exponentialTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.exponentialTab.Controls.Add(this.lambdaNumeric);
            this.exponentialTab.Controls.Add(this.lambdaLbl);
            this.exponentialTab.Location = new System.Drawing.Point(4, 42);
            this.exponentialTab.Name = "exponentialTab";
            this.exponentialTab.Padding = new System.Windows.Forms.Padding(3);
            this.exponentialTab.Size = new System.Drawing.Size(214, 58);
            this.exponentialTab.TabIndex = 1;
            this.exponentialTab.Text = "Exponential";
            // 
            // lambdaNumeric
            // 
            this.lambdaNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lambdaNumeric.DecimalPlaces = 3;
            this.lambdaNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.lambdaNumeric.Location = new System.Drawing.Point(30, 6);
            this.lambdaNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.lambdaNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.lambdaNumeric.Name = "lambdaNumeric";
            this.lambdaNumeric.Size = new System.Drawing.Size(178, 20);
            this.lambdaNumeric.TabIndex = 7;
            this.lambdaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lambdaLbl
            // 
            this.lambdaLbl.AutoSize = true;
            this.lambdaLbl.Location = new System.Drawing.Point(8, 8);
            this.lambdaLbl.Name = "lambdaLbl";
            this.lambdaLbl.Size = new System.Drawing.Size(17, 14);
            this.lambdaLbl.TabIndex = 6;
            this.lambdaLbl.Text = "λ:";
            // 
            // erlangTab
            // 
            this.erlangTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.erlangTab.Controls.Add(this.nNumeric);
            this.erlangTab.Controls.Add(this.nLbl);
            this.erlangTab.Controls.Add(this.lambdaErlangNumeric);
            this.erlangTab.Controls.Add(this.lambdaLbl2);
            this.erlangTab.Location = new System.Drawing.Point(4, 23);
            this.erlangTab.Name = "erlangTab";
            this.erlangTab.Padding = new System.Windows.Forms.Padding(3);
            this.erlangTab.Size = new System.Drawing.Size(214, 77);
            this.erlangTab.TabIndex = 2;
            this.erlangTab.Text = "Erlang";
            // 
            // nNumeric
            // 
            this.nNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.nNumeric.Location = new System.Drawing.Point(30, 32);
            this.nNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumeric.Name = "nNumeric";
            this.nNumeric.Size = new System.Drawing.Size(178, 20);
            this.nNumeric.TabIndex = 11;
            this.nNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nLbl
            // 
            this.nLbl.AutoSize = true;
            this.nLbl.Location = new System.Drawing.Point(8, 34);
            this.nLbl.Name = "nLbl";
            this.nLbl.Size = new System.Drawing.Size(17, 14);
            this.nLbl.TabIndex = 10;
            this.nLbl.Text = "n:";
            // 
            // lambdaErlangNumeric
            // 
            this.lambdaErlangNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lambdaErlangNumeric.DecimalPlaces = 3;
            this.lambdaErlangNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.lambdaErlangNumeric.Location = new System.Drawing.Point(30, 6);
            this.lambdaErlangNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.lambdaErlangNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.lambdaErlangNumeric.Name = "lambdaErlangNumeric";
            this.lambdaErlangNumeric.Size = new System.Drawing.Size(178, 20);
            this.lambdaErlangNumeric.TabIndex = 9;
            this.lambdaErlangNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lambdaLbl2
            // 
            this.lambdaLbl2.AutoSize = true;
            this.lambdaLbl2.Location = new System.Drawing.Point(8, 8);
            this.lambdaLbl2.Name = "lambdaLbl2";
            this.lambdaLbl2.Size = new System.Drawing.Size(17, 14);
            this.lambdaLbl2.TabIndex = 8;
            this.lambdaLbl2.Text = "λ:";
            // 
            // normalTab
            // 
            this.normalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.normalTab.Controls.Add(this.sigmaNumeric);
            this.normalTab.Controls.Add(this.sigmaLbl);
            this.normalTab.Controls.Add(this.mNumeric);
            this.normalTab.Controls.Add(this.mLbl);
            this.normalTab.Location = new System.Drawing.Point(4, 42);
            this.normalTab.Name = "normalTab";
            this.normalTab.Padding = new System.Windows.Forms.Padding(3);
            this.normalTab.Size = new System.Drawing.Size(214, 58);
            this.normalTab.TabIndex = 3;
            this.normalTab.Text = "Normal";
            // 
            // sigmaNumeric
            // 
            this.sigmaNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sigmaNumeric.DecimalPlaces = 3;
            this.sigmaNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.sigmaNumeric.Location = new System.Drawing.Point(29, 32);
            this.sigmaNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sigmaNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.sigmaNumeric.Name = "sigmaNumeric";
            this.sigmaNumeric.Size = new System.Drawing.Size(178, 20);
            this.sigmaNumeric.TabIndex = 11;
            this.sigmaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sigmaLbl
            // 
            this.sigmaLbl.AutoSize = true;
            this.sigmaLbl.Location = new System.Drawing.Point(7, 34);
            this.sigmaLbl.Name = "sigmaLbl";
            this.sigmaLbl.Size = new System.Drawing.Size(18, 14);
            this.sigmaLbl.TabIndex = 10;
            this.sigmaLbl.Text = "σ:";
            // 
            // mNumeric
            // 
            this.mNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mNumeric.DecimalPlaces = 3;
            this.mNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.mNumeric.Location = new System.Drawing.Point(29, 6);
            this.mNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.mNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(178, 20);
            this.mNumeric.TabIndex = 9;
            // 
            // mLbl
            // 
            this.mLbl.AutoSize = true;
            this.mLbl.Location = new System.Drawing.Point(7, 8);
            this.mLbl.Name = "mLbl";
            this.mLbl.Size = new System.Drawing.Size(17, 14);
            this.mLbl.TabIndex = 8;
            this.mLbl.Text = "μ:";
            // 
            // seedBox
            // 
            this.seedBox.Controls.Add(this.seedNumeric);
            this.seedBox.Controls.Add(this.useRandomSeedCheck);
            this.seedBox.Location = new System.Drawing.Point(8, 124);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(222, 72);
            this.seedBox.TabIndex = 10;
            this.seedBox.TabStop = false;
            this.seedBox.Text = "Seed";
            this.seedBox.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxesPaint);
            // 
            // seedNumeric
            // 
            this.seedNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.seedNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
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
            this.seedNumeric.Size = new System.Drawing.Size(212, 20);
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
            this.elementsCountNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.elementsCountNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.elementsCountNumeric.Location = new System.Drawing.Point(111, 98);
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
            this.elementsCountLbl.Location = new System.Drawing.Point(9, 100);
            this.elementsCountLbl.Name = "elementsCountLbl";
            this.elementsCountLbl.Size = new System.Drawing.Size(96, 14);
            this.elementsCountLbl.TabIndex = 8;
            this.elementsCountLbl.Text = "Elements count:";
            // 
            // groupCountNumeric
            // 
            this.groupCountNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupCountNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.groupCountNumeric.Location = new System.Drawing.Point(93, 72);
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
            this.groupCountLbl.Location = new System.Drawing.Point(9, 74);
            this.groupCountLbl.Name = "groupCountLbl";
            this.groupCountLbl.Size = new System.Drawing.Size(78, 14);
            this.groupCountLbl.TabIndex = 6;
            this.groupCountLbl.Text = "Group count:";
            // 
            // heightNumeric
            // 
            this.heightNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.heightNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
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
            this.widthNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.widthNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
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
            this.generateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.generateBtn.Location = new System.Drawing.Point(536, 333);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(236, 47);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // numberPageList
            // 
            this.numberPageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberPageList.Location = new System.Drawing.Point(535, 386);
            this.numberPageList.Name = "numberPageList";
            this.numberPageList.NumberList = null;
            this.numberPageList.Size = new System.Drawing.Size(236, 163);
            this.numberPageList.TabIndex = 4;
            // 
            // poissonTab
            // 
            this.poissonTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.poissonTab.Controls.Add(this.poissonLambdaNumeric);
            this.poissonTab.Controls.Add(this.poissonLambdaLbl);
            this.poissonTab.Location = new System.Drawing.Point(4, 42);
            this.poissonTab.Name = "poissonTab";
            this.poissonTab.Size = new System.Drawing.Size(214, 58);
            this.poissonTab.TabIndex = 4;
            this.poissonTab.Text = "Poisson";
            // 
            // poissonLambdaNumeric
            // 
            this.poissonLambdaNumeric.BackColor = System.Drawing.SystemColors.ControlLight;
            this.poissonLambdaNumeric.DecimalPlaces = 3;
            this.poissonLambdaNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.poissonLambdaNumeric.Location = new System.Drawing.Point(30, 6);
            this.poissonLambdaNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.poissonLambdaNumeric.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.poissonLambdaNumeric.Name = "poissonLambdaNumeric";
            this.poissonLambdaNumeric.Size = new System.Drawing.Size(178, 20);
            this.poissonLambdaNumeric.TabIndex = 9;
            this.poissonLambdaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // poissonLambdaLbl
            // 
            this.poissonLambdaLbl.AutoSize = true;
            this.poissonLambdaLbl.Location = new System.Drawing.Point(8, 8);
            this.poissonLambdaLbl.Name = "poissonLambdaLbl";
            this.poissonLambdaLbl.Size = new System.Drawing.Size(17, 14);
            this.poissonLambdaLbl.TabIndex = 8;
            this.poissonLambdaLbl.Text = "λ:";
            // 
            // GeneartionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(174)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.numberPageList);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.configurationBox);
            this.Controls.Add(this.histogramPicBox);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.Name = "GeneartionMainForm";
            this.Text = "Generation application";
            ((System.ComponentModel.ISupportInitialize)(this.histogramPicBox)).EndInit();
            this.configurationBox.ResumeLayout(false);
            this.configurationBox.PerformLayout();
            this.distributionTabControl.ResumeLayout(false);
            this.uniformTab.ResumeLayout(false);
            this.uniformTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumeric)).EndInit();
            this.exponentialTab.ResumeLayout(false);
            this.exponentialTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumeric)).EndInit();
            this.erlangTab.ResumeLayout(false);
            this.erlangTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaErlangNumeric)).EndInit();
            this.normalTab.ResumeLayout(false);
            this.normalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            this.seedBox.ResumeLayout(false);
            this.seedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumeric)).EndInit();
            this.poissonTab.ResumeLayout(false);
            this.poissonTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poissonLambdaNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox histogramPicBox;
        private System.Windows.Forms.GroupBox configurationBox;
        private System.Windows.Forms.NumericUpDown heightNumeric;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.NumericUpDown widthNumeric;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label groupCountLbl;
        private System.Windows.Forms.NumericUpDown elementsCountNumeric;
        private System.Windows.Forms.Label elementsCountLbl;
        private System.Windows.Forms.NumericUpDown groupCountNumeric;
        private System.Windows.Forms.GroupBox seedBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.CheckBox useRandomSeedCheck;
        private System.Windows.Forms.NumericUpDown seedNumeric;
        private NumberPageList numberPageList;
        private System.Windows.Forms.TabControl distributionTabControl;
        private System.Windows.Forms.TabPage uniformTab;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.Label bLbl;
        private System.Windows.Forms.NumericUpDown aNumeric;
        private System.Windows.Forms.Label aLbl;
        private System.Windows.Forms.TabPage exponentialTab;
        private System.Windows.Forms.TabPage erlangTab;
        private System.Windows.Forms.NumericUpDown lambdaNumeric;
        private System.Windows.Forms.Label lambdaLbl;
        private System.Windows.Forms.NumericUpDown nNumeric;
        private System.Windows.Forms.Label nLbl;
        private System.Windows.Forms.NumericUpDown lambdaErlangNumeric;
        private System.Windows.Forms.Label lambdaLbl2;
        private System.Windows.Forms.TabPage normalTab;
        private System.Windows.Forms.NumericUpDown sigmaNumeric;
        private System.Windows.Forms.Label sigmaLbl;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.Label mLbl;
        private System.Windows.Forms.TabPage poissonTab;
        private System.Windows.Forms.NumericUpDown poissonLambdaNumeric;
        private System.Windows.Forms.Label poissonLambdaLbl;
    }
}

