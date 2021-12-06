
using System.Drawing;

namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmLol
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
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbm
            // 
            this.btnAbm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAbm.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAbm.Location = new System.Drawing.Point(82, 78);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(133, 52);
            this.btnAbm.TabIndex = 0;
            this.btnAbm.Text = "ABM Partidas";
            this.btnAbm.UseVisualStyleBackColor = false;
            this.btnAbm.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegion.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRegion.Location = new System.Drawing.Point(82, 245);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(133, 51);
            this.btnRegion.TabIndex = 3;
            this.btnRegion.Text = "Mostrar todas las partidas";
            this.btnRegion.UseVisualStyleBackColor = false;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAnalisis.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAnalisis.Location = new System.Drawing.Point(82, 160);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(133, 52);
            this.btnAnalisis.TabIndex = 4;
            this.btnAnalisis.Text = "Analisis";
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // frmLol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.btnAbm);
            this.Name = "frmLol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLol_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbm;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnAnalisis;
    }
}