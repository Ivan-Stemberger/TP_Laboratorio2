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
    public partial class frmLol : Form
    {
        public frmLol()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmLolAbm frmLolAbm = new frmLolAbm();
            frmLolAbm.ShowDialog();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            FrmLolGames frmLolGames = new FrmLolGames();
            frmLolGames.ShowDialog();
        }

        private void frmLol_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImportExport<Lol> export = new ImportExport<Lol>(ListadoLol.getListaLol());
            if(export.lista != null)
            {
                export.exportAll();
            }
            
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            frmLolAnalisis frmLolAnalisis = new frmLolAnalisis();
            frmLolAnalisis.ShowDialog();
        }
    }
}
