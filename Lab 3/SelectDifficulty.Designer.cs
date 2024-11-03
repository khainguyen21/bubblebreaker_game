namespace Lab_3
{
    partial class SelectDifficulty
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
            this.UI_Easy_rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Medium_rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Hard_rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Difficult_gbx = new System.Windows.Forms.GroupBox();
            this.UI_OK_btn = new System.Windows.Forms.Button();
            this.UI_Cancel_btn = new System.Windows.Forms.Button();
            this.UI_Difficult_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Easy_rbtn
            // 
            this.UI_Easy_rbtn.AutoSize = true;
            this.UI_Easy_rbtn.Location = new System.Drawing.Point(39, 42);
            this.UI_Easy_rbtn.Name = "UI_Easy_rbtn";
            this.UI_Easy_rbtn.Size = new System.Drawing.Size(59, 20);
            this.UI_Easy_rbtn.TabIndex = 0;
            this.UI_Easy_rbtn.TabStop = true;
            this.UI_Easy_rbtn.Text = "Easy";
            this.UI_Easy_rbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Medium_rbtn
            // 
            this.UI_Medium_rbtn.AutoSize = true;
            this.UI_Medium_rbtn.Location = new System.Drawing.Point(39, 95);
            this.UI_Medium_rbtn.Name = "UI_Medium_rbtn";
            this.UI_Medium_rbtn.Size = new System.Drawing.Size(79, 20);
            this.UI_Medium_rbtn.TabIndex = 1;
            this.UI_Medium_rbtn.TabStop = true;
            this.UI_Medium_rbtn.Text = "Medium ";
            this.UI_Medium_rbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Hard_rbtn
            // 
            this.UI_Hard_rbtn.AutoSize = true;
            this.UI_Hard_rbtn.Location = new System.Drawing.Point(39, 147);
            this.UI_Hard_rbtn.Name = "UI_Hard_rbtn";
            this.UI_Hard_rbtn.Size = new System.Drawing.Size(58, 20);
            this.UI_Hard_rbtn.TabIndex = 2;
            this.UI_Hard_rbtn.TabStop = true;
            this.UI_Hard_rbtn.Text = "Hard";
            this.UI_Hard_rbtn.UseVisualStyleBackColor = true;
            // 
            // UI_Difficult_gbx
            // 
            this.UI_Difficult_gbx.Controls.Add(this.UI_Easy_rbtn);
            this.UI_Difficult_gbx.Controls.Add(this.UI_Hard_rbtn);
            this.UI_Difficult_gbx.Controls.Add(this.UI_Medium_rbtn);
            this.UI_Difficult_gbx.Location = new System.Drawing.Point(57, 48);
            this.UI_Difficult_gbx.Name = "UI_Difficult_gbx";
            this.UI_Difficult_gbx.Size = new System.Drawing.Size(275, 214);
            this.UI_Difficult_gbx.TabIndex = 3;
            this.UI_Difficult_gbx.TabStop = false;
            this.UI_Difficult_gbx.Text = "Difficulty ";
            // 
            // UI_OK_btn
            // 
            this.UI_OK_btn.Location = new System.Drawing.Point(79, 308);
            this.UI_OK_btn.Name = "UI_OK_btn";
            this.UI_OK_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_btn.TabIndex = 4;
            this.UI_OK_btn.Text = "OK";
            this.UI_OK_btn.UseVisualStyleBackColor = true;
            this.UI_OK_btn.Click += new System.EventHandler(this.UI_OK_btn_Click);
            // 
            // UI_Cancel_btn
            // 
            this.UI_Cancel_btn.Location = new System.Drawing.Point(257, 308);
            this.UI_Cancel_btn.Name = "UI_Cancel_btn";
            this.UI_Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_btn.TabIndex = 5;
            this.UI_Cancel_btn.Text = "Cancel ";
            this.UI_Cancel_btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_btn.Click += new System.EventHandler(this.UI_Cancel_btn_Click);
            // 
            // SelectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 430);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Cancel_btn);
            this.Controls.Add(this.UI_OK_btn);
            this.Controls.Add(this.UI_Difficult_gbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDifficulty";
            this.Text = "SelectDifficulty";
            this.UI_Difficult_gbx.ResumeLayout(false);
            this.UI_Difficult_gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton UI_Easy_rbtn;
        private System.Windows.Forms.RadioButton UI_Medium_rbtn;
        private System.Windows.Forms.RadioButton UI_Hard_rbtn;
        private System.Windows.Forms.GroupBox UI_Difficult_gbx;
        private System.Windows.Forms.Button UI_OK_btn;
        private System.Windows.Forms.Button UI_Cancel_btn;
    }
}