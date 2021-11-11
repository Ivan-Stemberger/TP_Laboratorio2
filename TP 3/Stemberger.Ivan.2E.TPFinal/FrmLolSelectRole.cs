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
    public partial class FrmLolSelectRole : Form
    {
        public FrmLolSelectRole()
        {
            InitializeComponent();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolRole("TOP");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolRole());

            frmLolRole frmLolRole = new frmLolRole();
            frmLolRole.ShowDialog();
        }

        private void btnJungle_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolRole("JUNGLE");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolRole());

            frmLolRole frmLolRole = new frmLolRole();
            frmLolRole.ShowDialog();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolRole("MID");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolRole());

            frmLolRole frmLolRole = new frmLolRole();
            frmLolRole.ShowDialog();
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolRole("ADC");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolRole());

            frmLolRole frmLolRole = new frmLolRole();
            frmLolRole.ShowDialog();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            ListadoLol.filtroLolRole("SUPPORT");
            ListadoLol.populateListaDefinitiva(ListadoLol.getLolRole());

            frmLolRole frmLolRole = new frmLolRole();
            frmLolRole.ShowDialog();
        }
    }
}
