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
    public partial class frmTftSelectRank : Form
    {
        public frmTftSelectRank()
        {
            InitializeComponent();
        }

        private void btnBronze_Click(object sender, EventArgs e)
        {
            ListadoTft.filtroTftRank("Bronze");
            ListadoTft.populateListaDefinitiva(ListadoTft.getTftElo());

            frmTftRank frmTftRank = new frmTftRank();
            frmTftRank.ShowDialog();
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            ListadoTft.filtroTftRank("Silver");
            ListadoTft.populateListaDefinitiva(ListadoTft.getTftElo());

            frmTftRank frmTftRank = new frmTftRank();
            frmTftRank.ShowDialog();
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            ListadoTft.filtroTftRank("Gold");
            ListadoTft.populateListaDefinitiva(ListadoTft.getTftElo());

            frmTftRank frmTftRank = new frmTftRank();
            frmTftRank.ShowDialog();
        }

        private void btnPlatinum_Click(object sender, EventArgs e)
        {
            ListadoTft.filtroTftRank("Platinum");
            ListadoTft.populateListaDefinitiva(ListadoTft.getTftElo());

            frmTftRank frmTftRank = new frmTftRank();
            frmTftRank.ShowDialog();
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            ListadoTft.filtroTftRank("Diamond");
            ListadoTft.populateListaDefinitiva(ListadoTft.getTftElo());

            frmTftRank frmTftRank = new frmTftRank();
            frmTftRank.ShowDialog();
        }
    }
}
