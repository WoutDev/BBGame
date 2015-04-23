namespace BBGame
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
            this.pnlSpeelveld = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlSpeelveld
            // 
            this.pnlSpeelveld.BackColor = System.Drawing.Color.Black;
            this.pnlSpeelveld.Location = new System.Drawing.Point(12, 12);
            this.pnlSpeelveld.Name = "pnlSpeelveld";
            this.pnlSpeelveld.Size = new System.Drawing.Size(638, 373);
            this.pnlSpeelveld.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(835, 81);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label1";
            // 
            // levenLabel
            // 
            this.levenLabel.AutoSize = true;
            this.levenLabel.Location = new System.Drawing.Point(838, 245);
            this.levenLabel.Name = "levenLabel";
            this.levenLabel.Size = new System.Drawing.Size(35, 13);
            this.levenLabel.TabIndex = 2;
            this.levenLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 518);
            this.Controls.Add(this.levenLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pnlSpeelveld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpeelveld;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label levenLabel;
    }
}

