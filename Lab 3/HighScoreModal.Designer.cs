namespace Lab_3
{
    partial class HighScoreModal
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
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Name_tbx = new System.Windows.Forms.TextBox();
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(250, 101);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_Btn.TabIndex = 7;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(54, 101);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_Btn.TabIndex = 6;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Name_tbx
            // 
            this.UI_Name_tbx.Location = new System.Drawing.Point(143, 45);
            this.UI_Name_tbx.Name = "UI_Name_tbx";
            this.UI_Name_tbx.Size = new System.Drawing.Size(182, 22);
            this.UI_Name_tbx.TabIndex = 5;
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Location = new System.Drawing.Point(51, 48);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(86, 16);
            this.UI_Name_Lbl.TabIndex = 4;
            this.UI_Name_Lbl.Text = "Player Name";
            // 
            // HighScoreModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 188);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_Name_tbx);
            this.Controls.Add(this.UI_Name_Lbl);
            this.Name = "HighScoreModal";
            this.Text = "HighScoreModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.TextBox UI_Name_tbx;
        private System.Windows.Forms.Label UI_Name_Lbl;
    }
}