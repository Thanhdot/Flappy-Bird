
namespace FlappyBird
{
    partial class playorquit
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
            this.playagain = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNtimes new roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "You Lose";
            // 
            // playagain
            // 
            this.playagain.Location = new System.Drawing.Point(68, 56);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(75, 23);
            this.playagain.TabIndex = 3;
            this.playagain.Text = "Play Again";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(68, 85);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 4;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Location = new System.Drawing.Point(69, 121);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(39, 15);
            this.textScore.TabIndex = 5;
            this.textScore.Text = "Score:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0";
            // 
            // playorquit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 148);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.label1);
            this.Name = "playorquit";
            this.Text = "6-";
            this.Load += new System.EventHandler(this.playorquit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.TextBox textBox1;
    }
}