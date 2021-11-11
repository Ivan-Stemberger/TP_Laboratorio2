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
    public partial class frmLolSelectElo : Form
    {
        public frmLolSelectElo()
        {
            InitializeComponent();
        }

        private void btnBronze_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolElo("Bronze");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolElo());
            FrmLolElo FrmLolElo = new FrmLolElo();
            FrmLolElo.ShowDialog();
        }
        
        private void btnSilver_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolElo("Silver");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolElo());
            FrmLolElo FrmLolElo = new FrmLolElo();
            FrmLolElo.ShowDialog();
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolElo("Gold");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolElo());

            FrmLolElo FrmLolElo = new FrmLolElo();
            FrmLolElo.ShowDialog();
        }

        private void btnPlatinum_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolElo("Platinum");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolElo());
            FrmLolElo FrmLolElo = new FrmLolElo();
            FrmLolElo.ShowDialog();
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolElo("Diamond");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolElo());
            FrmLolElo FrmLolElo = new FrmLolElo();
            FrmLolElo.ShowDialog();
        }
    }
}
