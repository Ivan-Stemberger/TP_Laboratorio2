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
    public partial class frmTftSelection : Form
    {
        public frmTftSelection()
        {
            InitializeComponent();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            frmTftSelectRank frmTftSelectRank = new frmTftSelectRank();
            frmTftSelectRank.ShowDialog();
        }

        private void btnAbm_Click(object sender, EventArgs e)
        {
            frmTftAbm frmTftAbm = new frmTftAbm();
            frmTftAbm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTftGame frmTftGame = new frmTftGame();
            frmTftGame.ShowDialog();
        }

        private void frmTftSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImportExport<Tft> export = new ImportExport<Tft>(ListadoTft.getListaTft());
            if (export.lista != null)
            {
                export.exportAll();
            }
        }
    }
}
