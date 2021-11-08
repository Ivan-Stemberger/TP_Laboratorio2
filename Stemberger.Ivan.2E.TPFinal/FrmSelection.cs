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
using System.IO;

namespace Stemberger.Ivan._2E.TPFinal
{
    public partial class FrmSelection : Form
    {
        public FrmSelection()
        {
            InitializeComponent();
        }

        
        private void btnLeague_Click(object sender, EventArgs e)
        {
            try
            {
                frmLol frmLol = new frmLol();
                string name = "Complete list of Lol games.xml";
                if (!File.Exists(name))
                {
                    ListadoLol.populateLolList();
                }
                else
                {
                    ImportExport<Lol> import = new ImportExport<Lol>(ListadoLol.getListaLol());
                    ListadoLol.setListaLol(import.Import());
                    if (ListadoLol.getListaLol() == null || ListadoLol.getListaLol().Count == 0)
                    {
                        fileEmptyException ex = new fileEmptyException();
                        throw ex;
                    }
                }
                frmLol.ShowDialog();
            }
            catch(fileEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTft_Click(object sender, EventArgs e)
        {
            try
            {
                frmTftSelection frmTftSelection = new frmTftSelection();
                string name = "Complete list of Tft games.xml";

                if (!File.Exists(name))
                {
                    ListadoTft.populateTftList();
                }
                else
                {
                    ImportExport<Tft> import = new ImportExport<Tft>(ListadoTft.getListaTft());
                    ListadoTft.setListaTft(import.Import());
                    if (ListadoTft.getListaTft() == null || ListadoTft.getListaTft().Count == 0)
                    {
                        ListadoTft.populateTftList();
                        fileEmptyException ex = new fileEmptyException();
                        throw ex;
                    }
                }

                frmTftSelection.ShowDialog();
            }
            catch (fileEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
