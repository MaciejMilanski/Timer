namespace Timer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbReturn = new System.Windows.Forms.ToolStripButton();
            this.tbbHelp = new System.Windows.Forms.ToolStripButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.DescDataPicker = new System.Windows.Forms.Label();
            this.tbbQuit = new System.Windows.Forms.ToolStripButton();
            this.bSave = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbReturn,
            this.tbbHelp,
            this.tbbQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbReturn
            // 
            this.tbbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbReturn.Image = ((System.Drawing.Image)(resources.GetObject("tbbReturn.Image")));
            this.tbbReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbReturn.Name = "tbbReturn";
            this.tbbReturn.Size = new System.Drawing.Size(59, 24);
            this.tbbReturn.Text = "Powrót";
            this.tbbReturn.Click += new System.EventHandler(this.TBBReturn_Click);
            // 
            // tbbHelp
            // 
            this.tbbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tbbHelp.Image")));
            this.tbbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbHelp.Name = "tbbHelp";
            this.tbbHelp.Size = new System.Drawing.Size(58, 24);
            this.tbbHelp.Text = "Pomoc";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // DescDataPicker
            // 
            this.DescDataPicker.AutoSize = true;
            this.DescDataPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescDataPicker.Location = new System.Drawing.Point(12, 46);
            this.DescDataPicker.Name = "DescDataPicker";
            this.DescDataPicker.Size = new System.Drawing.Size(116, 20);
            this.DescDataPicker.TabIndex = 2;
            this.DescDataPicker.Text = "Wybrana Data";
            // 
            // tbbQuit
            // 
            this.tbbQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tbbQuit.Image")));
            this.tbbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbQuit.Name = "tbbQuit";
            this.tbbQuit.Size = new System.Drawing.Size(63, 24);
            this.tbbQuit.Text = "Wyjście";
            this.tbbQuit.Click += new System.EventHandler(this.TBBQuit_Click);
            // 
            // bSave
            // 
            this.bSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSave.Location = new System.Drawing.Point(0, 116);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(289, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 139);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.DescDataPicker);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbbReturn;
        private System.Windows.Forms.ToolStripButton tbbHelp;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label DescDataPicker;
        private System.Windows.Forms.ToolStripButton tbbQuit;
        private System.Windows.Forms.Button bSave;
    }
}