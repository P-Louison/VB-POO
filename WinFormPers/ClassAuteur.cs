using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPers
{
    public class Auteur
    {
        private int Id;
        private string Nom;
        private string AnneeNaissance;


        public Auteur(int id, string nom, string anneeNaissance)
        {
            this.Id = id;
            this.Nom = nom;
            this.AnneeNaissance = anneeNaissance;
        }

        public int GetId()
        {
            return Id;
        }
        // Autres accesseurs a coder éventuellement...

        public override string ToString()
        {
            return Nom + " - "+ AnneeNaissance.ToString();
            // Ce qui apparaitra dans la liste
        }
    }
}
