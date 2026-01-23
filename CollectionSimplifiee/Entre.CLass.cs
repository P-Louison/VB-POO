using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSimplifiee
{
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
