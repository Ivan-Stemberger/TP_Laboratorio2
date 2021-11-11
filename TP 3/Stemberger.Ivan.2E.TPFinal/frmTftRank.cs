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
    public partial class frmTftRank : Form
    {
        public frmTftRank()
        {
            InitializeComponent();
            dtgvTftRank.DataSource = ListadoTft.getTftListaDefinitiva();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListadoTft.getTftListaDefinitiva() == null || ListadoTft.getTftListaDefinitiva().Count != 0)
                {
                    ImportExport<Tft> Export = new ImportExport<Tft>(ListadoTft.getTftListaDefinitiva());
                    Export.exportAnalisis("Rank");
                }
                else
                {
                    listEmptyorNullException ex = new listEmptyorNullException();
                    throw ex;
                }
            }
            catch(listEmptyorNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
