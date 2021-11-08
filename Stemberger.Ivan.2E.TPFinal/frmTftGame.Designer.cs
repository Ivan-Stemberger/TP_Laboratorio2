
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmTftGame
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
            this.dtgvTftGames = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTftGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTftGames
            // 
            this.dtgvTftGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTftGames.Location = new System.Drawing.Point(150, 12);
            this.dtgvTftGames.Name = "dtgvTftGames";
            this.dtgvTftGames.RowTemplate.Height = 25;
            this.dtgvTftGames.Size = new System.Drawing.Size(545, 259);
            this.dtgvTftGames.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(593, 299);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(102, 59);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar Partidas";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmTftGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtgvTftGames);
            this.Name = "frmTftGame";
            this.Text = "frmTftGame";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTftGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTftGames;
        private System.Windows.Forms.Button btnExport;
    }
}