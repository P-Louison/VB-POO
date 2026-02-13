using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPers
{
    public class Editeur
    {
        private int Id;
        private string Nom;
        private string compagny;

        private string Adresse;
        private string Ville;
        private string CodePostal;

        public Editeur(int Id, string Nom,string compagnyName, string Adresse, string Ville, string CodePostal)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.CodePostal = CodePostal;
        }

        public int GetId()
        {
            return Id;
        }
        // Autres accesseurs a coder éventuellement...

        public override string ToString()
        {
            return Nom + " - " + Adresse + " - " + Ville + " - " + CodePostal;
            // Ce qui apparaitra dans la liste
        }
    }
}