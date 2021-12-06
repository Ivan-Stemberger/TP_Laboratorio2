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
    public partial class frmLolAnalisis : Form
    {
        public event DelegadoAnalisis analisis;

        public frmLolAnalisis()
        {
            InitializeComponent();
            analisis+= setWinRate;
            analisis+= setPickRate;

        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            analisis.Invoke();
        }

        private void setWinRate()
        {
            Lol lol = new Lol();

            txtGlobalWR.Text = lol.analisisGlobal(cbxChampion.Text,0);
            txtRegionMayorWR.Text = lol.analisisRegionMayor(cbxChampion.Text,0);
            txtRegionMenorWR.Text = lol.analisisRegionMenor(cbxChampion.Text,0);
            txtRolMayorWR.Text = lol.analisisRolMayor(cbxChampion.Text, 0);
            txtRolMenorWR.Text = lol.analisisRolMenor(cbxChampion.Text, 0);
            txtEloMayorWR.Text = lol.analisisEloMayor(cbxChampion.Text, 0);
            txtEloMenorWR.Text = lol.analisisEloMenor(cbxChampion.Text, 0);
        }

        private void setPickRate()
        {
            Lol lol = new Lol();

            txtGlobalPR.Text = lol.analisisGlobal(cbxChampion.Text,1);
            txtRegionMayorPR.Text = lol.analisisRegionMayor(cbxChampion.Text, 1);
            txtRegionMenorPR.Text = lol.analisisRegionMenor(cbxChampion.Text, 1);
            txtRolMayorPR.Text = lol.analisisRolMayor(cbxChampion.Text, 1);
            txtRolMenorPR.Text = lol.analisisRolMenor(cbxChampion.Text, 1);
            txtEloMayorPR.Text = lol.analisisEloMayor(cbxChampion.Text, 1);
            txtEloMenorPR.Text = lol.analisisEloMenor(cbxChampion.Text, 1);
        }

    }
}
