
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class FrmLolGames
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
            this.dtgvGames = new System.Windows.Forms.DataGridView();
            this.dtgvChampion = new System.Windows.Forms.DataGridView();
            this.dtgvElo = new System.Windows.Forms.DataGridView();
            this.dtgvRole = new System.Windows.Forms.DataGridView();
            this.dtgvRegion = new System.Windows.Forms.DataGridView();
            this.dtgvCounter = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChampion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvElo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGames
            // 
            this.dtgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGames.Location = new System.Drawing.Point(12, 12);
            this.dtgvGames.Name = "dtgvGames";
            this.dtgvGames.RowTemplate.Height = 25;
            this.dtgvGames.Size = new System.Drawing.Size(621, 278);
            this.dtgvGames.TabIndex = 0;
            // 
            // dtgvChampion
            // 
            this.dtgvChampion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChampion.Location = new System.Drawing.Point(12, 12);
            this.dtgvChampion.Name = "dtgvChampion";
            this.dtgvChampion.RowTemplate.Height = 25;
            this.dtgvChampion.Size = new System.Drawing.Size(621, 278);
            this.dtgvChampion.TabIndex = 14;
            // 
            // dtgvElo
            // 
            this.dtgvElo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvElo.Location = new System.Drawing.Point(12, 12);
            this.dtgvElo.Name = "dtgvElo";
            this.dtgvElo.RowTemplate.Height = 25;
            this.dtgvElo.Size = new System.Drawing.Size(621, 278);
            this.dtgvElo.TabIndex = 15;
            // 
            // dtgvRole
            // 
            this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRole.Location = new System.Drawing.Point(12, 12);
            this.dtgvRole.Name = "dtgvRole";
            this.dtgvRole.RowTemplate.Height = 25;
            this.dtgvRole.Size = new System.Drawing.Size(621, 278);
            this.dtgvRole.TabIndex = 16;
            // 
            // dtgvRegion
            // 
            this.dtgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegion.Location = new System.Drawing.Point(12, 12);
            this.dtgvRegion.Name = "dtgvRegion";
            this.dtgvRegion.RowTemplate.Height = 25;
            this.dtgvRegion.Size = new System.Drawing.Size(621, 278);
            this.dtgvRegion.TabIndex = 17;
            // 
            // dtgvCounter
            // 
            this.dtgvCounter.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dtgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCounter.GridColor = System.Drawing.Color.SkyBlue;
            this.dtgvCounter.Location = new System.Drawing.Point(12, 12);
            this.dtgvCounter.Name = "dtgvCounter";
            this.dtgvCounter.ReadOnly = true;
            this.dtgvCounter.RowTemplate.Height = 25;
            this.dtgvCounter.Size = new System.Drawing.Size(621, 278);
            this.dtgvCounter.TabIndex = 18;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExport.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExport.Location = new System.Drawing.Point(796, 327);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmLolGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.dtgvCounter);
            this.Controls.Add(this.dtgvRegion);
            this.Controls.Add(this.dtgvRole);
            this.Controls.Add(this.dtgvElo);
            this.Controls.Add(this.dtgvChampion);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dtgvGames);
            this.Name = "FrmLolGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLolRegion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChampion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvElo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGames;
        private System.Windows.Forms.DataGridView dtgvChampion;
        private System.Windows.Forms.DataGridView dtgvElo;
        private System.Windows.Forms.DataGridView dtgvRole;
        private System.Windows.Forms.DataGridView dtgvRegion;
        private System.Windows.Forms.DataGridView dtgvCounter;
        private System.Windows.Forms.Button btnExport;
    }
}