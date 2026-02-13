using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormPers
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblCase1_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnChoixQuatre_Click(object sender, EventArgs e)
        {
            PageAjoutLivre pageAjoutLivre = new PageAjoutLivre();
            pageAjoutLivre.ShowDialog();
        }

        private void btnChoixDeux_Click(object sender, EventArgs e)
        {
            PageAjouterEditeur pageAjouterEditeur = new PageAjouterEditeur();
            pageAjouterEditeur.ShowDialog();
        }

        private void btnChoixUn_Click(object sender, EventArgs e)
        {
            PageAfficherEditeur pageAfficherEditeur = new PageAfficherEditeur();
            pageAfficherEditeur.ShowDialog();
        }

        private void btnChoixTrois_Click(object sender, EventArgs e)
        {
            PageDelete pagedelete = new PageDelete();
            pagedelete.ShowDialog();
        }
    }
}
