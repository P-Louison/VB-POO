using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Tourisme : Vehicule
    {
        private int nombreDePortes;
        private int nombreDePassager;
        private bool climatisation;


        public Tourisme(string code, string libelle, double prixJour, int pNombreDePortes, int pNombreDePassager, bool pClimatisation) 
            : base(code,libelle,prixJour)
        {
            this.nombreDePassager = pNombreDePassager;
            this.nombreDePortes = pNombreDePortes;
            this.climatisation = pClimatisation;
        }

        public int GetNombreDePortes()
        {
            return nombreDePortes;
        }

        public int GetNombreDePassager()
        {
            return nombreDePassager;
        }

        public bool GetClimatisation()
        {
            return climatisation;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNombre de portes : " + nombreDePortes +
                 "\nNombre de passagers : " + nombreDePassager +
                 "\nClimatisation : " + climatisation +
                 "\nCoût location : " + this.CoutLocation(5);
        }


    }
}
