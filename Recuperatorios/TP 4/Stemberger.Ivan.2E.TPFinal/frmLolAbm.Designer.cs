
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmLolAbm
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
            this.cbxChampion = new System.Windows.Forms.ComboBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxElo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxResult = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxChampion
            // 
            this.cbxChampion.FormattingEnabled = true;
            this.cbxChampion.Items.AddRange(new object[] {
            "Caitlyn",
            "Jhin",
            "Leona",
            "Ziggs",
            "Alistar",
            "Zoe",
            "Rumble",
            "Graves",
            "LeeSin",
            "Syndra",
            "Nocturne",
            "Ryze",
            "Akali",
            "Zhilean",
            "Qiyanna",
            "Talon",
            "Aphelios"});
            this.cbxChampion.Location = new System.Drawing.Point(279, 55);
            this.cbxChampion.Name = "cbxChampion";
            this.cbxChampion.Size = new System.Drawing.Size(121, 23);
            this.cbxChampion.TabIndex = 0;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "ADC",
            "TOP",
            "MID",
            "JUNGLE",
            "SUPPORT"});
            this.cbxRole.Location = new System.Drawing.Point(279, 103);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 23);
            this.cbxRole.TabIndex = 1;
            // 
            // cbxElo
            // 
            this.cbxElo.FormattingEnabled = true;
            this.cbxElo.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond"});
            this.cbxElo.Location = new System.Drawing.Point(279, 147);
            this.cbxElo.Name = "cbxElo";
            this.cbxElo.Size = new System.Drawing.Size(121, 23);
            this.cbxElo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Champion*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elo*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Location = new System.Drawing.Point(72, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 55);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar Partida";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSearch.Location = new System.Drawing.Point(279, 291);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 55);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar Partida";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(485, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 55);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Borrar Partida";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(279, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID (Solo Búsqueda)";
            // 
            // cbxResult
            // 
            this.cbxResult.FormattingEnabled = true;
            this.cbxResult.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxResult.Location = new System.Drawing.Point(279, 246);
            this.cbxResult.Name = "cbxResult";
            this.cbxResult.Size = new System.Drawing.Size(121, 23);
            this.cbxResult.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Result*";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "NA",
            "EUW",
            "EUEast",
            "Brazil",
            "LAS",
            "LAN",
            "Asia",
            "OCE"});
            this.cbxRegion.Location = new System.Drawing.Point(279, 196);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 23);
            this.cbxRegion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(186, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Region*";
            // 
            // frmLolAbm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(703, 354);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxElo);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.cbxChampion);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "frmLolAbm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChampion;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxElo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label label7;
    }
}