﻿
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
            this.btnAbm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAbm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAbm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbm.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAbm.Location = new System.Drawing.Point(317, 73);
            this.btnAbm.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(117, 68);
            this.btnAbm.TabIndex = 0;
            this.btnAbm.Text = "ABM de Partidas";
            this.btnAbm.UseVisualStyleBackColor = false;
            this.btnAbm.Click += new System.EventHandler(this.btnAbm_Click);
            // 
            // btnRank
            // 
            this.btnRank.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRank.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRank.Location = new System.Drawing.Point(317, 155);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(117, 68);
            this.btnRank.TabIndex = 2;
            this.btnRank.Text = "Analisis";
            this.btnRank.UseVisualStyleBackColor = false;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(317, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lista de Partidas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTftSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnAbm);
            this.Name = "frmTftSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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