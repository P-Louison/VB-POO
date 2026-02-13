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
    public partial class PageDelete : Form
    {
        public PageDelete()
        {
            InitializeComponent();
        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string requête, ISBN;

            NpgsqlConnection maCnx;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");

            ISBN = tbxISBN.Text;

            maCnx.Open();

            requête = "Delete from titleauthor where isbn = @isbn; Delete from titles where isbn = @isbn";
            var maCde = new NpgsqlCommand(requête, maCnx);
            maCde.Parameters.AddWithValue("@isbn", ISBN);
            maCde.ExecuteNonQuery();


            maCnx.Close();
            MessageBox.Show("Suppresion faite");

        }
    }
}
