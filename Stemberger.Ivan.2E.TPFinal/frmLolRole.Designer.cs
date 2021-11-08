
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmLolRole
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
            this.dtgvLolElo = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLolElo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLolElo
            // 
            this.dtgvLolElo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLolElo.Location = new System.Drawing.Point(101, 12);
            this.dtgvLolElo.Name = "dtgvLolElo";
            this.dtgvLolElo.RowTemplate.Height = 25;
            this.dtgvLolElo.Size = new System.Drawing.Size(579, 271);
            this.dtgvLolElo.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(584, 300);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 50);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar Análisis";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmLolRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtgvLolElo);
            this.Name = "frmLolRole";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLolElo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLolElo;
        private System.Windows.Forms.Button btnExport;
    }
}