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
        private Entre[] tab = new Entre[MAX];
        private int positionLibre;
        private int i = 0;

        public Collection() 
        {
            positionLibre = 0;
        }


        private int GetIndice(string pCle)
        {
            for (i = 0; i < positionLibre; i++) 
            {
                if (tab[i].getCle() == pCle)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Ajouter(string cCle, object cValeur)
        {
            if (positionLibre > MAX)
            {
                return false;
            }
            else
            {
                tab[positionLibre] = new Entre(cCle, cValeur);
                positionLibre++;
                return true;           
            }
        }

        public object Retourner(string cle)
        {
            if (GetIndice(cle) != -1)
            {
                return tab[GetIndice(cle)].getValeur();
            }
            return null;    
        }

        public bool Supprimer(string cle)
        {
            if ((positionLibre <= 0) || (positionLibre > MAX) || (GetIndice(cle) == -1))
            {
                return false;
            }
            else
            {
                for (int j = GetIndice(cle); j < positionLibre - 1; j++)
                {
                    tab[j] = tab[j + 1];
                }
                positionLibre--;
                return true;
            }
        }

        public override string ToString()
        {
            string chaine = string.Empty;
            for (i = 0; i < positionLibre; i++)
            {
                chaine = chaine + tab[i].ToString() + "\n";
            }
            return chaine;
        }

        public bool Existe(string cle)
        {
            if (GetIndice(cle) != -1) { return true; } 
            return false;
        }

        public void Vider()
        {
            positionLibre = 0;
        }

        public int NombreDElement()
        {
            return positionLibre;
        }

    }
}