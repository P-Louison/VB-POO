using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSimplifiee
{


    public class Collection
    {
        private const int MAX = 5;
        Entre[,] tab = new Entre[MAX,2]; //erreur possible !!
        private int positionLibre = 0;
        private int i = 0;

        public bool Ajouter(string cCle, object cValeur)
        {
            if (positionLibre > MAX)
            {
                return false;
            }
            else
            {
                tab[positionLibre] = [cCle, cValeur];
                positionLibre++;
               
            }
            return true;
        }

        public object Retourner(string cle)
        {
            for (i = 0; i <= tab.Length; ++i)
            {
                if (tab[i] == cle)
                {
                    return tab[i,1];
                }
            }
            return null;
        }

        public bool Supprimer(string cle)
        {
            for (i = 0; i <= tab.Length; ++i)
            {
                if (tab[i] == cle)
                {
                    tab[i] = tab[]
                }
            }
            return null;
        }














    

    public class Entre
    {

        private string cle;
        private object valeur;

        public Entre(string pCle, object pValeur)
        {
            cle = pCle;
            valeur = pValeur;
        }

        public string getCle()
        {
            return cle;
        }

        public Object getValeur()
        {
            return valeur;
        }

        public override string ToString()
        {
            string chaine = string.Empty;
            chaine = "la cle est : " + cle.ToString() + "la valeur est : " + valeur.ToString();
            return chaine;
        }
    }
}
