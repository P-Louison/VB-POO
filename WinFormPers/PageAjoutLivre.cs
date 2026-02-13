using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPers
{
    public partial class PageAjoutLivre : Form
    {
        

        public PageAjoutLivre()
        {
            InitializeComponent();
            

            NpgsqlDataReader jeuEnr = null;
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");

            maCnx.Open();
            string requête;
            requête = "Select pubid,name,company_name,address,city,zip from publishers";
            var maCde = new NpgsqlCommand(requête, maCnx);
            jeuEnr = maCde.ExecuteReader();
            string nom, nomcompagny, adresse, city, codePostale;
            int pubid;
            while (jeuEnr.Read())
            {

                pubid = (int)jeuEnr["pubid"];
                nom = jeuEnr["name"].ToString();
                adresse = jeuEnr["address"].ToString();
                nomcompagny = jeuEnr["company_name"].ToString();
                city = jeuEnr["city"].ToString();
                codePostale = jeuEnr["zip"].ToString();

                cmbEditeur.Items.Add(new Editeur(pubid, nom, nomcompagny, adresse, city, codePostale));
            }
            maCnx.Close();

            


            maCnx.Open ();
            string requête2, nomAuteur;
            int idAuteur;
            
            requête2 = "Select au_id,author,year_born from authors";
            var maCde2 = new NpgsqlCommand(requête2, maCnx);
            jeuEnr = maCde2.ExecuteReader();

            while (jeuEnr.Read())
            {
                idAuteur = (int)jeuEnr["au_id"];
                nomAuteur = jeuEnr["author"].ToString();
                 string anneeNaissance = jeuEnr["year_born"].ToString();
                lbxAuteur.Items.Add(new Auteur(idAuteur, nomAuteur, anneeNaissance));

            }

            maCnx.Close ();
        }

        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
