using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinal.ClassLibrary;

namespace Stemberger.Ivan._2E.TPFinal
{
    public partial class frmTftAnalisis : Form
    {
        
        public frmTftAnalisis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tft tft = new Tft();

            txtPickRate.Text = tft.analisisGlobal(cbxComposicion.Text);
            txtEloMayorPR.Text = tft.analisisEloMayor(cbxComposicion.Text);
            txtEloMenorPR.Text = tft.analisisEloMenor(cbxComposicion.Text);

        }
    }
}
