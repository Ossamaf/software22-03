namespace WindowsFormsApp1
{
    partial class Form1
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
            this.aantalworpen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EyesAmountupdown = new System.Windows.Forms.NumericUpDown();
            this.worpamountsupdown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totaantal = new System.Windows.Forms.Label();
            this.worpen = new System.Windows.Forms.Label();
            this.ExportWorpBox = new System.Windows.Forms.ListBox();
            this.TotalAmountEyes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyesAmountupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worpamountsupdown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aantalworpen
            // 
            this.aantalworpen.AutoSize = true;
            this.aantalworpen.Location = new System.Drawing.Point(6, 27);
            this.aantalworpen.Name = "aantalworpen";
            this.aantalworpen.Size = new System.Drawing.Size(74, 13);
            this.aantalworpen.TabIndex = 0;
            this.aantalworpen.Text = "aantal worpen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EyesAmountupdown);
            this.groupBox1.Controls.Add(this.worpamountsupdown);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.aantalworpen);
            this.groupBox1.Location = new System.Drawing.Point(46, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aantal ogen:";
            // 
            // EyesAmountupdown
            // 
            this.EyesAmountupdown.Location = new System.Drawing.Point(46, 91);
            this.EyesAmountupdown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.EyesAmountupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EyesAmountupdown.Name = "EyesAmountupdown";
            this.EyesAmountupdown.Size = new System.Drawing.Size(120, 20);
            this.EyesAmountupdown.TabIndex = 3;
            this.EyesAmountupdown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // worpamountsupdown
            // 
            this.worpamountsupdown.Location = new System.Drawing.Point(46, 48);
            this.worpamountsupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.worpamountsupdown.Name = "worpamountsupdown";
            this.worpamountsupdown.Size = new System.Drawing.Size(120, 20);
            this.worpamountsupdown.TabIndex = 2;
            this.worpamountsupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalAmountEyes);
            this.groupBox2.Controls.Add(this.totaantal);
            this.groupBox2.Controls.Add(this.worpen);
            this.groupBox2.Controls.Add(this.ExportWorpBox);
            this.groupBox2.Location = new System.Drawing.Point(306, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // totaantal
            // 
            this.totaantal.AutoSize = true;
            this.totaantal.Location = new System.Drawing.Point(15, 184);
            this.totaantal.Name = "totaantal";
            this.totaantal.Size = new System.Drawing.Size(99, 13);
            this.totaantal.TabIndex = 2;
            this.totaantal.Text = "Totaal aantal ogen:";
            // 
            // worpen
            // 
            this.worpen.AutoSize = true;
            this.worpen.Location = new System.Drawing.Point(15, 27);
            this.worpen.Name = "worpen";
            this.worpen.Size = new System.Drawing.Size(45, 13);
            this.worpen.TabIndex = 1;
            this.worpen.Text = "worpen:";
            // 
            // ExportWorpBox
            // 
            this.ExportWorpBox.FormattingEnabled = true;
            this.ExportWorpBox.Location = new System.Drawing.Point(38, 48);
            this.ExportWorpBox.Name = "ExportWorpBox";
            this.ExportWorpBox.Size = new System.Drawing.Size(120, 121);
            this.ExportWorpBox.TabIndex = 0;
            // 
            // TotalAmountEyes
            // 
            this.TotalAmountEyes.AutoSize = true;
            this.TotalAmountEyes.Location = new System.Drawing.Point(120, 184);
            this.TotalAmountEyes.Name = "TotalAmountEyes";
            this.TotalAmountEyes.Size = new System.Drawing.Size(0, 13);
            this.TotalAmountEyes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyesAmountupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worpamountsupdown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aantalworpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label worpen;
        private System.Windows.Forms.ListBox ExportWorpBox;
        private System.Windows.Forms.NumericUpDown worpamountsupdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EyesAmountupdown;
        private System.Windows.Forms.Label totaantal;
        private System.Windows.Forms.Label TotalAmountEyes;
    }
}

