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
            tasks();
        }

        private void tasks()
        {
            
            Task t2 = new Task(cargaLol);
            Task t1 = new Task(cargaTft);

            t2.Start();
            t1.Wait(3000);
            t1.Start();
            
        }

        private void cargaLol()
        {
            List<Lol> lista = new List<Lol>();
            ListadoLol.setListaLol(SqlHandler.GetLolGames());
            lista = ListadoLol.getListaLol();

            if (lista == null)
            {
                fileEmptyException ex = new fileEmptyException();
                throw ex;
            }
        }

        private void cargaTft()
        {
            List<Tft> lista = new List<Tft>();
            ListadoTft.setListaTft(SqlHandler.GetTftGames());
            lista = ListadoTft.getListaTft();

            if (lista == null)
            {
                fileEmptyException ex = new fileEmptyException();
                throw ex;
            }
        }
        private void btnLeague_Click(object sender, EventArgs e)
        {
            try
            {
                
                frmLol frmLol = new frmLol();
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

                
                frmTftSelection.ShowDialog();
            }
            catch (fileEmptyException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
