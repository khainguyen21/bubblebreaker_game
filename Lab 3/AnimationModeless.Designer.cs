namespace Lab_3
{
    partial class AnimationModeless
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
            this.UI_Animation_TrkBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Animation_TrkBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Animation_TrkBar
            // 
            this.UI_Animation_TrkBar.Location = new System.Drawing.Point(140, 102);
            this.UI_Animation_TrkBar.Maximum = 200;
            this.UI_Animation_TrkBar.Minimum = 10;
            this.UI_Animation_TrkBar.Name = "UI_Animation_TrkBar";
            this.UI_Animation_TrkBar.Size = new System.Drawing.Size(471, 56);
            this.UI_Animation_TrkBar.TabIndex = 1;
            this.UI_Animation_TrkBar.TickFrequency = 10;
            this.UI_Animation_TrkBar.Value = 10;
            this.UI_Animation_TrkBar.Scroll += new System.EventHandler(this.UI_TrackBarScroll);
            // 
            // AnimationModeless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 226);
            this.Controls.Add(this.UI_Animation_TrkBar);
            this.Name = "AnimationModeless";
            this.Text = "AnimationModeless";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_ClosingModeless);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Animation_TrkBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Animation_TrkBar;
    }
}