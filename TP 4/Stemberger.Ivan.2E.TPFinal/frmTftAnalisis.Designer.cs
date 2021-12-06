
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmTftAnalisis
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
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPickRate = new System.Windows.Forms.TextBox();
            this.txtEloMayorPR = new System.Windows.Forms.TextBox();
            this.txtEloMenorPR = new System.Windows.Forms.TextBox();
            this.cbxComposicion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAnalisis.Location = new System.Drawing.Point(22, 112);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(103, 54);
            this.btnAnalisis.TabIndex = 0;
            this.btnAnalisis.Text = "Iniciar Analisis";
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Composición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pick Rate Global";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elo con mayor Pick Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Elo con menor Pick Rate";
            // 
            // txtPickRate
            // 
            this.txtPickRate.Location = new System.Drawing.Point(275, 50);
            this.txtPickRate.Name = "txtPickRate";
            this.txtPickRate.ReadOnly = true;
            this.txtPickRate.Size = new System.Drawing.Size(100, 23);
            this.txtPickRate.TabIndex = 10;
            // 
            // txtEloMayorPR
            // 
            this.txtEloMayorPR.Location = new System.Drawing.Point(275, 99);
            this.txtEloMayorPR.Name = "txtEloMayorPR";
            this.txtEloMayorPR.ReadOnly = true;
            this.txtEloMayorPR.Size = new System.Drawing.Size(100, 23);
            this.txtEloMayorPR.TabIndex = 12;
            // 
            // txtEloMenorPR
            // 
            this.txtEloMenorPR.Location = new System.Drawing.Point(275, 143);
            this.txtEloMenorPR.Name = "txtEloMenorPR";
            this.txtEloMenorPR.ReadOnly = true;
            this.txtEloMenorPR.Size = new System.Drawing.Size(100, 23);
            this.txtEloMenorPR.TabIndex = 14;
            // 
            // cbxComposicion
            // 
            this.cbxComposicion.FormattingEnabled = true;
            this.cbxComposicion.Items.AddRange(new object[] {
            "TANK",
            "ASSASINS",
            "YORDLES",
            "MAGES",
            "DPS"});
            this.cbxComposicion.Location = new System.Drawing.Point(22, 27);
            this.cbxComposicion.Name = "cbxComposicion";
            this.cbxComposicion.Size = new System.Drawing.Size(121, 23);
            this.cbxComposicion.TabIndex = 16;
            // 
            // frmTftAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(419, 199);
            this.Controls.Add(this.cbxComposicion);
            this.Controls.Add(this.txtEloMenorPR);
            this.Controls.Add(this.txtEloMayorPR);
            this.Controls.Add(this.txtPickRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalisis);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "frmTftAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTftAnalisis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPickRate;
        private System.Windows.Forms.TextBox txtEloMayorPR;
        private System.Windows.Forms.TextBox txtEloMenorPR;
        private System.Windows.Forms.ComboBox cbxComposicion;
    }
}