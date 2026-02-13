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
    public partial class PageAjouterEditeur : Form
    {


        

        public PageAjouterEditeur()
        {
            InitializeComponent();
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string requête, nom, adresse, ville, cp;
            
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");

            maCnx.Open(); 

            nom = tbxNomPrenom.Text;
            adresse = tbxAdresse.Text;
            ville = tbxVille.Text;
            cp = tbxCodePostale.Text;


            requête = "insert into publishers (name, address, city, zip) values(@nom, @adresse, @ville, @codepostale)";
            var maCde = new NpgsqlCommand(requête, maCnx);
            maCde.Parameters.AddWithValue("@nom", nom);
            maCde.Parameters.AddWithValue("@adresse", adresse);
            maCde.Parameters.AddWithValue("@ville", ville);
            maCde.Parameters.AddWithValue("@codepostale", cp);

            maCde.ExecuteNonQuery();

            maCnx.Close();

            MessageBox.Show("Ajout valider");

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
