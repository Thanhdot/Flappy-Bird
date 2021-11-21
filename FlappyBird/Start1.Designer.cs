
namespace FlappyBird
{
    partial class Start1
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
            this.start2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start2
            // 
            this.start2.AutoSize = true;
            this.start2.Font = new System.Drawing.Font("VNI-Korin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start2.Location = new System.Drawing.Point(28, 9);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(226, 27);
            this.start2.TabIndex = 0;
            this.start2.Text = "Welcome to Flappy Bird";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(98, 47);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(98, 76);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 23);
            this.quit.TabIndex = 2;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Start1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.start2);
            this.Name = "Start1";
            this.Text = "Start1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button quit;
    }
}