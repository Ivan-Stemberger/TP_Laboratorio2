
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmTftSelection
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
            this.btnAbm = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbm
            // 
            this.btnAbm.Location = new System.Drawing.Point(237, 73);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(117, 68);
            this.btnAbm.TabIndex = 0;
            this.btnAbm.Text = "ABM de Partidas";
            this.btnAbm.UseVisualStyleBackColor = true;
            this.btnAbm.Click += new System.EventHandler(this.btnAbm_Click);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(440, 73);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(117, 68);
            this.btnRank.TabIndex = 2;
            this.btnRank.Text = "Analisis por Rank";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lista de Partidas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTftSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnAbm);
            this.Name = "frmTftSelection";
            this.Text = "frmTftSelection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTftSelection_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbm;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button button4;
    }
}