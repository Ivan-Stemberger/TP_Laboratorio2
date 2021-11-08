
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class FrmLolElo
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
            this.brnBack = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLolElo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLolElo
            // 
            this.dtgvLolElo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLolElo.Location = new System.Drawing.Point(122, 12);
            this.dtgvLolElo.Name = "dtgvLolElo";
            this.dtgvLolElo.RowTemplate.Height = 25;
            this.dtgvLolElo.Size = new System.Drawing.Size(561, 251);
            this.dtgvLolElo.TabIndex = 0;
            // 
            // brnBack
            // 
            this.brnBack.Location = new System.Drawing.Point(12, 12);
            this.brnBack.Name = "brnBack";
            this.brnBack.Size = new System.Drawing.Size(75, 23);
            this.brnBack.TabIndex = 1;
            this.brnBack.Text = "Volver";
            this.brnBack.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(567, 298);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(116, 54);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Descargar Análisis";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FrmLolElo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.brnBack);
            this.Controls.Add(this.dtgvLolElo);
            this.Name = "FrmLolElo";
            this.Text = "FrmLolElo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLolElo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLolElo;
        private System.Windows.Forms.Button brnBack;
        private System.Windows.Forms.Button btnDownload;
    }
}