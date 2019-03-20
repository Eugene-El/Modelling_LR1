namespace GenerationApplication
{
    partial class NumberPageList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.numbersList = new System.Windows.Forms.ListBox();
            this.pageTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rightBtn
            // 
            this.rightBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightBtn.Location = new System.Drawing.Point(120, 0);
            this.rightBtn.MinimumSize = new System.Drawing.Size(30, 0);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(30, 141);
            this.rightBtn.TabIndex = 9;
            this.rightBtn.Text = "⏵";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftBtn.Location = new System.Drawing.Point(0, 0);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(30, 141);
            this.leftBtn.TabIndex = 8;
            this.leftBtn.Text = "⏴";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // numbersList
            // 
            this.numbersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numbersList.FormattingEnabled = true;
            this.numbersList.Location = new System.Drawing.Point(30, 0);
            this.numbersList.Margin = new System.Windows.Forms.Padding(30);
            this.numbersList.Name = "numbersList";
            this.numbersList.Size = new System.Drawing.Size(90, 121);
            this.numbersList.TabIndex = 7;
            // 
            // pageTxt
            // 
            this.pageTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageTxt.Location = new System.Drawing.Point(30, 121);
            this.pageTxt.Name = "pageTxt";
            this.pageTxt.ReadOnly = true;
            this.pageTxt.Size = new System.Drawing.Size(90, 20);
            this.pageTxt.TabIndex = 10;
            this.pageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberPageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pageTxt);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.numbersList);
            this.Name = "NumberPageList";
            this.Size = new System.Drawing.Size(150, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.ListBox numbersList;
        private System.Windows.Forms.TextBox pageTxt;
    }
}
