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
    public partial class frmTftGame : Form
    {
        public frmTftGame()
        {
            InitializeComponent();
            dtgvTftGames.DataSource = ListadoTft.getListaTft();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ImportExport<Tft> Export = new ImportExport<Tft>(ListadoTft.getListaTft());
            Export.exportAll();
        }
    }
}
