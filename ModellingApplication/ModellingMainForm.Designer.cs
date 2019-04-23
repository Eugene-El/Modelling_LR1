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
            // ModellingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(939, 451);
            this.Controls.Add(this.modelLogsBox);
            this.Controls.Add(this.transactStoryBox);
            this.Controls.Add(this.transactsBox);
            this.Controls.Add(this.modelBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ModellingMainForm";
            this.Text = "Modelling application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modelBtn;
        private System.Windows.Forms.ListBox transactsBox;
        private System.Windows.Forms.ListBox transactStoryBox;
        private System.Windows.Forms.ListBox modelLogsBox;
    }
}

