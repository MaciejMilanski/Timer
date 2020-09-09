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
            this.tbSettings = new System.Windows.Forms.ToolStrip();
            this.tbbReturn = new System.Windows.Forms.ToolStripButton();
            this.tbbQuit = new System.Windows.Forms.ToolStripButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.DescDataPicker = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.tbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSettings
            // 
            this.tbSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbReturn,
            this.tbbQuit});
            this.tbSettings.Location = new System.Drawing.Point(0, 0);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(296, 27);
            this.tbSettings.TabIndex = 0;
            this.tbSettings.Text = "toolStrip1";
            // 
            // tbbReturn
            // 
            this.tbbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbReturn.Image = ((System.Drawing.Image)(resources.GetObject("tbbReturn.Image")));
            this.tbbReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbReturn.Name = "tbbReturn";
            this.tbbReturn.Size = new System.Drawing.Size(56, 24);
            this.tbbReturn.Text = "Return";
            this.tbbReturn.Click += new System.EventHandler(this.tbbReturn_Click);
            // 
            // tbbQuit
            // 
            this.tbbQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tbbQuit.Image")));
            this.tbbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbQuit.Name = "tbbQuit";
            this.tbbQuit.Size = new System.Drawing.Size(41, 28);
            this.tbbQuit.Text = "Quit";
            this.tbbQuit.Click += new System.EventHandler(this.tbbQuit_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MMMMdd, yyyy  |  hh:mm tt";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(12, 69);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(264, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // DescDataPicker
            // 
            this.DescDataPicker.AutoSize = true;
            this.DescDataPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescDataPicker.Location = new System.Drawing.Point(12, 46);
            this.DescDataPicker.Name = "DescDataPicker";
            this.DescDataPicker.Size = new System.Drawing.Size(45, 20);
            this.DescDataPicker.TabIndex = 2;
            this.DescDataPicker.Text = "Date";
            // 
            // bSave
            // 
            this.bSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSave.Location = new System.Drawing.Point(0, 109);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(296, 30);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 139);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.DescDataPicker);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tbSettings.ResumeLayout(false);
            this.tbSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbSettings;
        private System.Windows.Forms.ToolStripButton tbbReturn;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label DescDataPicker;
        private System.Windows.Forms.ToolStripButton tbbQuit;
        private System.Windows.Forms.Button bSave;
    }
}