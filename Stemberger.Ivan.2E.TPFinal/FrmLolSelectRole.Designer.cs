
namespace Stemberger.Ivan._2E.TPFinal
{
    partial class FrmLolSelectRole
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
            this.btnTop = new System.Windows.Forms.Button();
            this.btnJungle = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnAdc = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(209, 69);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(113, 60);
            this.btnTop.TabIndex = 0;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnJungle
            // 
            this.btnJungle.Location = new System.Drawing.Point(438, 69);
            this.btnJungle.Name = "btnJungle";
            this.btnJungle.Size = new System.Drawing.Size(113, 60);
            this.btnJungle.TabIndex = 1;
            this.btnJungle.Text = "Jungle";
            this.btnJungle.UseVisualStyleBackColor = true;
            this.btnJungle.Click += new System.EventHandler(this.btnJungle_Click);
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(99, 177);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(113, 60);
            this.btnMid.TabIndex = 2;
            this.btnMid.Text = "Mid";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnAdc
            // 
            this.btnAdc.Location = new System.Drawing.Point(320, 177);
            this.btnAdc.Name = "btnAdc";
            this.btnAdc.Size = new System.Drawing.Size(113, 60);
            this.btnAdc.TabIndex = 3;
            this.btnAdc.Text = "Adc";
            this.btnAdc.UseVisualStyleBackColor = true;
            this.btnAdc.Click += new System.EventHandler(this.btnAdc_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(556, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "Support";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // FrmLolSelectRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAdc);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnJungle);
            this.Controls.Add(this.btnTop);
            this.Name = "FrmLolSelectRole";
            this.Text = "FrmLolRole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnJungle;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnAdc;
        private System.Windows.Forms.Button button5;
    }
}