
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmLolSelectElo
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
            this.btnPlatinum = new System.Windows.Forms.Button();
            this.btnGold = new System.Windows.Forms.Button();
            this.btnSilver = new System.Windows.Forms.Button();
            this.btnBronze = new System.Windows.Forms.Button();
            this.btnDiamond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBronze
            // 
            this.btnBronze.Location = new System.Drawing.Point(236, 51);
            this.btnBronze.Name = "btnBronze";
            this.btnBronze.Size = new System.Drawing.Size(105, 63);
            this.btnBronze.TabIndex = 0;
            this.btnBronze.Text = "Bronze";
            this.btnBronze.UseVisualStyleBackColor = true;
            this.btnBronze.Click += new System.EventHandler(this.btnBronze_Click);
            // 
            // btnSilver
            // 
            this.btnSilver.Location = new System.Drawing.Point(450, 51);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(105, 63);
            this.btnSilver.TabIndex = 1;
            this.btnSilver.Text = "Silver";
            this.btnSilver.UseVisualStyleBackColor = true;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // btnGold
            // 
            this.btnGold.Location = new System.Drawing.Point(131, 166);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(105, 63);
            this.btnGold.TabIndex = 2;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // btnPlatinum
            // 
            this.btnPlatinum.Location = new System.Drawing.Point(346, 166);
            this.btnPlatinum.Name = "btnPlatinum";
            this.btnPlatinum.Size = new System.Drawing.Size(105, 63);
            this.btnPlatinum.TabIndex = 3;
            this.btnPlatinum.Text = "Platinum";
            this.btnPlatinum.UseVisualStyleBackColor = true;
            this.btnPlatinum.Click += new System.EventHandler(this.btnPlatinum_Click);
            // 
            // btnDiamond
            // 
            this.btnDiamond.Location = new System.Drawing.Point(557, 166);
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(105, 63);
            this.btnDiamond.TabIndex = 4;
            this.btnDiamond.Text = "Diamond";
            this.btnDiamond.UseVisualStyleBackColor = true;
            this.btnDiamond.Click += new System.EventHandler(this.btnDiamond_Click);
            // 
            // frmLolSelectElo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiamond);
            this.Controls.Add(this.btnPlatinum);
            this.Controls.Add(this.btnGold);
            this.Controls.Add(this.btnSilver);
            this.Controls.Add(this.btnBronze);
            this.Name = "frmLolSelectElo";
            this.Text = "frmSelectElo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlatinum;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.Button btnBronze;
        private System.Windows.Forms.Button btnDiamond;
    }
}