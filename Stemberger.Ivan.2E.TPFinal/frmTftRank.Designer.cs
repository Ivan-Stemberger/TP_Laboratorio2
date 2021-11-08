
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmTftRank
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
            this.dtgvTftRank = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTftRank)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTftRank
            // 
            this.dtgvTftRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTftRank.Location = new System.Drawing.Point(159, 21);
            this.dtgvTftRank.Name = "dtgvTftRank";
            this.dtgvTftRank.RowTemplate.Height = 25;
            this.dtgvTftRank.Size = new System.Drawing.Size(513, 273);
            this.dtgvTftRank.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 31);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "btnVolver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(556, 300);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 48);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar Analisis";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmTftRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvTftRank);
            this.Name = "frmTftRank";
            this.Text = "frmTftRank";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTftRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTftRank;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExport;
    }
}