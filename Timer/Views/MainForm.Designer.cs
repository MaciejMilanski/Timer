namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbProgressBar = new CircularProgressBar.CircularProgressBar();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.TBBSettings = new System.Windows.Forms.ToolStripButton();
            this.TBBHelp = new System.Windows.Forms.ToolStripButton();
            this.TBBQuit = new System.Windows.Forms.ToolStripButton();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbProgressBar.AnimationSpeed = 500;
            this.pbProgressBar.BackColor = System.Drawing.Color.LightGray;
            this.pbProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pbProgressBar.ForeColor = System.Drawing.Color.DimGray;
            this.pbProgressBar.InnerColor = System.Drawing.Color.LightGray;
            this.pbProgressBar.InnerMargin = 2;
            this.pbProgressBar.InnerWidth = -1;
            this.pbProgressBar.Location = new System.Drawing.Point(39, 50);
            this.pbProgressBar.MarqueeAnimationSpeed = 2000;
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.OuterColor = System.Drawing.Color.RoyalBlue;
            this.pbProgressBar.OuterMargin = -25;
            this.pbProgressBar.OuterWidth = 13;
            this.pbProgressBar.ProgressColor = System.Drawing.Color.MidnightBlue;
            this.pbProgressBar.ProgressWidth = 13;
            this.pbProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbProgressBar.Size = new System.Drawing.Size(500, 500);
            this.pbProgressBar.StartAngle = 270;
            this.pbProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbProgressBar.SubscriptText = "";
            this.pbProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbProgressBar.SuperscriptText = "";
            this.pbProgressBar.TabIndex = 0;
            this.pbProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbProgressBar.Value = 68;
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBBSettings,
            this.TBBHelp,
            this.TBBQuit});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(582, 27);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "toolStrip1";
            // 
            // TBBSettings
            // 
            this.TBBSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBBSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBSettings.Name = "TBBSettings";
            this.TBBSettings.RightToLeftAutoMirrorImage = true;
            this.TBBSettings.Size = new System.Drawing.Size(85, 24);
            this.TBBSettings.Text = "Ustawienia";
            // 
            // TBBHelp
            // 
            this.TBBHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBBHelp.Image = ((System.Drawing.Image)(resources.GetObject("TBBHelp.Image")));
            this.TBBHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBHelp.Name = "TBBHelp";
            this.TBBHelp.Size = new System.Drawing.Size(58, 24);
            this.TBBHelp.Text = "Pomoc";
            // 
            // TBBQuit
            // 
            this.TBBQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TBBQuit.Image = ((System.Drawing.Image)(resources.GetObject("TBBQuit.Image")));
            this.TBBQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBBQuit.Name = "TBBQuit";
            this.TBBQuit.Size = new System.Drawing.Size(63, 24);
            this.TBBQuit.Text = "Wyjście";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(582, 587);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.pbProgressBar);
            this.Name = "MainForm";
            this.Text = "CountDown";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbProgressBar;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton TBBSettings;
        private System.Windows.Forms.ToolStripButton TBBHelp;
        private System.Windows.Forms.ToolStripButton TBBQuit;
    }
}

