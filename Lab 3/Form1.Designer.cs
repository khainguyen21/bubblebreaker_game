namespace Lab_3
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
            this.components = new System.ComponentModel.Container();
            this.UI_ShowScore_cbx = new System.Windows.Forms.CheckBox();
            this.UI_ShowAnimationSped_cbx = new System.Windows.Forms.CheckBox();
            this.UI_Play_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ShowScore_cbx
            // 
            this.UI_ShowScore_cbx.AutoSize = true;
            this.UI_ShowScore_cbx.Location = new System.Drawing.Point(228, 86);
            this.UI_ShowScore_cbx.Name = "UI_ShowScore_cbx";
            this.UI_ShowScore_cbx.Size = new System.Drawing.Size(104, 20);
            this.UI_ShowScore_cbx.TabIndex = 0;
            this.UI_ShowScore_cbx.Text = "Show Score ";
            this.UI_ShowScore_cbx.UseVisualStyleBackColor = true;
            this.UI_ShowScore_cbx.CheckedChanged += new System.EventHandler(this.ShowScore);
            // 
            // UI_ShowAnimationSped_cbx
            // 
            this.UI_ShowAnimationSped_cbx.AutoSize = true;
            this.UI_ShowAnimationSped_cbx.Location = new System.Drawing.Point(228, 144);
            this.UI_ShowAnimationSped_cbx.Name = "UI_ShowAnimationSped_cbx";
            this.UI_ShowAnimationSped_cbx.Size = new System.Drawing.Size(168, 20);
            this.UI_ShowAnimationSped_cbx.TabIndex = 1;
            this.UI_ShowAnimationSped_cbx.Text = "Show Animation Speed";
            this.UI_ShowAnimationSped_cbx.UseVisualStyleBackColor = true;
            this.UI_ShowAnimationSped_cbx.CheckedChanged += new System.EventHandler(this.UI_ShowAnimationSped_cbx_CheckedChanged);
            // 
            // UI_Play_btn
            // 
            this.UI_Play_btn.Location = new System.Drawing.Point(331, 247);
            this.UI_Play_btn.Name = "UI_Play_btn";
            this.UI_Play_btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Play_btn.TabIndex = 2;
            this.UI_Play_btn.Text = "Play";
            this.UI_Play_btn.UseVisualStyleBackColor = true;
            this.UI_Play_btn.Click += new System.EventHandler(this.UI_Play_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 422);
            this.Controls.Add(this.UI_Play_btn);
            this.Controls.Add(this.UI_ShowAnimationSped_cbx);
            this.Controls.Add(this.UI_ShowScore_cbx);
            this.Name = "Form1";
            this.Text = "CMPE1666 Lab 3 - BallZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowScore_cbx;
        private System.Windows.Forms.CheckBox UI_ShowAnimationSped_cbx;
        private System.Windows.Forms.Button UI_Play_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

