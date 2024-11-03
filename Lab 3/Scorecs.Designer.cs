namespace Lab_3
{
    partial class Scorecs
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Score_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // UI_Score_lbl
            // 
            this.UI_Score_lbl.AutoSize = true;
            this.UI_Score_lbl.Location = new System.Drawing.Point(224, 120);
            this.UI_Score_lbl.Name = "UI_Score_lbl";
            this.UI_Score_lbl.Size = new System.Drawing.Size(35, 16);
            this.UI_Score_lbl.TabIndex = 1;
            this.UI_Score_lbl.Text = "0000";
            this.UI_Score_lbl.TextChanged += new System.EventHandler(this.UI_ScoreUpdate);
            this.UI_Score_lbl.Click += new System.EventHandler(this.UI_Score_lbl_Click);
            // 
            // Scorecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 223);
            this.Controls.Add(this.UI_Score_lbl);
            this.Controls.Add(this.label1);
            this.Name = "Scorecs";
            this.Text = "Scorecs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_ModelessDialogClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_Score_lbl;
    }
}