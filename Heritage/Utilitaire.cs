using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Utilitaire : Vehicule
    {
        private int chargeUtile;
        private int longueur;
        private int largeur;
        private int hauteur;

        public Utilisataire(string code, string libelle, double prixJour, int pChargeUtile,int pLongueur, int pLargeur, int pHauteur)
            : base(code, libelle, prixJour)
        {
            this.chargeUtile = pChargeUtile;
            this.longueur = pLongueur;
            this.largeur = pLargeur;
            this hauteur = pHauteur;
        }

        public int GetChargeUtile()
        {
            return chargeUtile;
        }

        public int Volume()
        {
            return this.longueur * this.largeur * this.hauteur;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nCharge utile : " + chargeUtile.ToString() +
                 "\nLongueur : " + longueur.ToString() +
                 "\nLargeur : " + largeur.ToString() +
                "\nHauteur : " + hauteur.ToString() +
                 "\nVolume : " + this.Volume().ToString() +
                 "\nCoût location : " + this.CoutLocation(5);
        }
    }
}
