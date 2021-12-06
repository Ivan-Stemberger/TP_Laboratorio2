
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class frmTftAbm
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
            this.cbxComposition = new System.Windows.Forms.ComboBox();
            this.cbxRank = new System.Windows.Forms.ComboBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxComposition
            // 
            this.cbxComposition.FormattingEnabled = true;
            this.cbxComposition.Items.AddRange(new object[] {
            "Tanks",
            "Assassins",
            "Yordles",
            "Mages",
            "DPS"});
            this.cbxComposition.Location = new System.Drawing.Point(329, 99);
            this.cbxComposition.Name = "cbxComposition";
            this.cbxComposition.Size = new System.Drawing.Size(121, 23);
            this.cbxComposition.TabIndex = 0;
            // 
            // cbxRank
            // 
            this.cbxRank.FormattingEnabled = true;
            this.cbxRank.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond"});
            this.cbxRank.Location = new System.Drawing.Point(329, 160);
            this.cbxRank.Name = "cbxRank";
            this.cbxRank.Size = new System.Drawing.Size(121, 23);
            this.cbxRank.TabIndex = 1;
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth"});
            this.cbxPosition.Location = new System.Drawing.Point(329, 218);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(121, 23);
            this.cbxPosition.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(329, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 23);
            this.txtId.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(168, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 55);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar Partida";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(329, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 55);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar Partida";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Location = new System.Drawing.Point(492, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 55);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Borrar Partida";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Composition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Position";
            // 
            // frmTftAbm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.cbxRank);
            this.Controls.Add(this.cbxComposition);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "frmTftAbm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTftAbm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxComposition;
        private System.Windows.Forms.ComboBox cbxRank;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}