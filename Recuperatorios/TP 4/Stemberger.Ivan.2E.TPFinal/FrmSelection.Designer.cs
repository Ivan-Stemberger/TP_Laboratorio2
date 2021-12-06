
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class FrmSelection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeague = new System.Windows.Forms.Button();
            this.btnTft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeague
            // 
            this.btnLeague.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLeague.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLeague.Location = new System.Drawing.Point(200, 129);
            this.btnLeague.Name = "btnLeague";
            this.btnLeague.Size = new System.Drawing.Size(123, 67);
            this.btnLeague.TabIndex = 0;
            this.btnLeague.Text = "League of Legends";
            this.btnLeague.UseVisualStyleBackColor = false;
            this.btnLeague.Click += new System.EventHandler(this.btnLeague_Click);
            // 
            // btnTft
            // 
            this.btnTft.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTft.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnTft.Location = new System.Drawing.Point(433, 129);
            this.btnTft.Name = "btnTft";
            this.btnTft.Size = new System.Drawing.Size(120, 64);
            this.btnTft.TabIndex = 1;
            this.btnTft.Text = "TeamFight Tactics";
            this.btnTft.UseVisualStyleBackColor = false;
            this.btnTft.Click += new System.EventHandler(this.btnTft_Click);
            // 
            // FrmSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTft);
            this.Controls.Add(this.btnLeague);
            this.Name = "FrmSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeague;
        private System.Windows.Forms.Button btnTft;
    }
}

