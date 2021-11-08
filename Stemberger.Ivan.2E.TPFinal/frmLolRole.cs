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
    public partial class frmLolRole : Form
    {
        public frmLolRole()
        {
            InitializeComponent();
            dtgvLolElo.DataSource = ListadoLol.getLolListaDefinitiva();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ImportExport<Lol> Export = new ImportExport<Lol>(ListadoLol.getLolListaDefinitiva());
            Export.exportAnalisis("Role");
        }
    }
}
