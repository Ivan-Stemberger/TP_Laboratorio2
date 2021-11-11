
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
            this.btnElo = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbm
            // 
            this.btnAbm.Location = new System.Drawing.Point(159, 96);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(133, 52);
            this.btnAbm.TabIndex = 0;
            this.btnAbm.Text = "ABM Partidas";
            this.btnAbm.UseVisualStyleBackColor = true;
            this.btnAbm.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnElo
            // 
            this.btnElo.Location = new System.Drawing.Point(475, 96);
            this.btnElo.Name = "btnElo";
            this.btnElo.Size = new System.Drawing.Size(133, 52);
            this.btnElo.TabIndex = 1;
            this.btnElo.Text = "Analisis por Ranking";
            this.btnElo.UseVisualStyleBackColor = true;
            this.btnElo.Click += new System.EventHandler(this.btnElo_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(159, 212);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(133, 52);
            this.btnRole.TabIndex = 2;
            this.btnRole.Text = "Analisis por Rol";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(475, 212);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(133, 51);
            this.btnRegion.TabIndex = 3;
            this.btnRegion.Text = "Mostrar todas las partidas";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // frmLol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnElo);
            this.Controls.Add(this.btnAbm);
            this.Name = "frmLol";
            this.Text = "frmLol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLol_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbm;
        private System.Windows.Forms.Button btnElo;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnRegion;
    }
}