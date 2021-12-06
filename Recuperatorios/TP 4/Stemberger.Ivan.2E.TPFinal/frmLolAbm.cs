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
    public partial class frmLolAbm : Form
    {
        public frmLolAbm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Lol match = new Lol(cbxChampion.Text, cbxRole.Text, cbxElo.Text, cbxRegion.Text, int.Parse(cbxResult.Text));
                int id;

                if (int.TryParse(txtId.Text, out id) || txtId.Text == string.Empty)
                {
                    if (!ListadoLol.searchId(id))
                    {
                        ListadoLol.getListaLol().Add(match); ;
                        SqlHandler.insertLolMatch(match);
                    }
                    else
                    {
                        ListadoLol.editList(match, id);
                        SqlHandler.editLolMatch(match, id);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                if (int.TryParse(txtId.Text, out id))
                {
                    Lol game = ListadoLol.getGame(id);
                    if (game != null)
                    {
                        cbxChampion.Text = game.champion.ToString();
                        cbxRole.Text = game.role.ToString();
                        cbxElo.Text = game.rank.ToString();
                        cbxRegion.Text = game.region.ToString();
                        cbxResult.Text = game.Win.ToString();
                    }
                    else
                    {
                        idNotFoundException idNotFound = new idNotFoundException();
                        throw idNotFound;
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
                    ListadoLol.deleteLol(id);
                    SqlHandler.deleteLolMatch(id);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
