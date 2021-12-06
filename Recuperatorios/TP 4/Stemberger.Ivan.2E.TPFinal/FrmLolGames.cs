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
    public partial class FrmLolGames : Form
    {
        public FrmLolGames()
        {
            InitializeComponent();
            dtgvGames.DataSource = ListadoLol.getListaLol();
            dtgvChampion.Hide();
            dtgvElo.Hide();
            dtgvRegion.Hide();
            dtgvCounter.Hide();
            dtgvRole.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ImportExport<Lol> Export = new ImportExport<Lol>(ListadoLol.getListaLol());
            Export.exportAll();
        }


    }
}
