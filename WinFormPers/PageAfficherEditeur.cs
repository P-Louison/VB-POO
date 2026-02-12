using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;


namespace WinFormPers
{
    public partial class PageAfficherEditeur : Form
    {
        public PageAfficherEditeur()
        {
            InitializeComponent();
        }


        private void btnrechercher_Click(object sender, EventArgs e)
        {
            string requête, nom, unItem;
            lvResultat.Columns.Add("nom de l'auteur", 200);
            lvResultat.View = View.Details;
            

            NpgsqlDataReader jeuEnr = null;
            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");

            nom = tbxRechercher.Text + "%";


            maCnx.Open(); 

            requête = "Select * from publishers where name Like @lettre";
            var maCde = new NpgsqlCommand(requête, maCnx);
            maCde.Parameters.AddWithValue("@lettre", nom);
            
            jeuEnr = maCde.ExecuteReader();
            while (jeuEnr.Read())
            {


                unItem = jeuEnr["name"].ToString();
                lvResultat.Items.Add(new ListViewItem(unItem));
            }
            

            maCnx.Close();

        }

        

    }
}
