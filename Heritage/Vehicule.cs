using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Vehicule

    {
        // hérite de la classe Object (implicitement)
        private int vitesseDePointe;
        private int nombreDeRoues;
        private string couleur;

        public Vehicule(int vitesseDePointe, int nombreDeRoues, string couleur)
        {
            this.vitesseDePointe = vitesseDePointe;
            this.nombreDeRoues = nombreDeRoues;
            this.couleur = couleur;
        }

        public int GetVitesseDePointe()
        {
            return vitesseDePointe;
        }

        public int GetNombreDeRoues()
        {
            return nombreDeRoues;
        }

        public string GetCouleur()
        {
            return couleur;
        }
        // redéfinition – Overrides - du   ToString de la classe Object
        public override string ToString()
        {
            // renvoie la description en «clair » de notre véhicule
            return "\nVitesse de pointe : " + vitesseDePointe.ToString() + "\nCouleur : " + couleur + "\nNombre de roue : " + nombreDeRoues.ToString();
        }
    }
}
