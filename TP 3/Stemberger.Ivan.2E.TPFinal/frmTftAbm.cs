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
    public partial class frmTftAbm : Form
    {
        public frmTftAbm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(txtId.Text, out id) || txtId.Text == string.Empty)
                {
                    if (!ListadoTft.searchId(id))
                    {
                        ListadoTft.getListaTft().Add(new Tft(cbxComposition.Text, cbxRank.Text, cbxPosition.Text));
                    }
                    else
                    {
                        ListadoTft.editList(new Tft(cbxComposition.Text, cbxRank.Text, cbxPosition.Text), id);
                    }
                }
                else
                {
                    idNotFoundException idNotFound = new idNotFoundException();
                    throw idNotFound;
                }
            }
            catch(idNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                if (int.TryParse(txtId.Text, out id))
                {
                    Tft game = ListadoTft.getGame(id);
                    if (game != null)
                    {
                        cbxComposition.Text = game.composition.ToString();
                        cbxRank.Text = game.rank.ToString();
                        cbxPosition.Text = game.position.ToString();
                    }

                }
                else
                {
                    idNotFoundException idNotFound = new idNotFoundException();
                    throw idNotFound;
                }
            }
            catch (idNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(txtId.Text, out id))
                {
                    ListadoTft.deleteTft(id);
                }
                else
                {
                    idNotFoundException idNotFound = new idNotFoundException();
                    throw idNotFound;
                }
            }
            catch (idNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
