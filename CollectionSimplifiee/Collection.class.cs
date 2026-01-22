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
                tab[positionLibre] = new Entre(cCle, cValeur);
                positionLibre++;
            }
            return true;
        }

        public object Retourner(string cle)
        {
            foreach (var chaine in tab)
            {
                if (chaine.getCle() == cle)
                {
                    return chaine.getValeur();
                }
            }
            return null;
        }

        public bool Supprimer(string cle)
        {
            if ((positionLibre <= 0) || (positionLibre > MAX))
            {
                return false;
            }
            else
            {
                for (i = 0; i < positionLibre; i++)
                {
                    if (tab[i].getCle() == cle)
                    {
                        for (int j = i; j < positionLibre - 1; j++)
                        {
                            tab[j] = tab[j + 1];
                        }
                        tab[positionLibre - 1] = null;
                        positionLibre--;
                        return true;
                    }
                }
            }
            return false;   
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
            for (i = 0; i < positionLibre; i++)
            {
                if (tab[i].getCle() == cle)
                {
                    return true;
                }
            }
            return false;
        }

        public void Vider()
        {
            for (i = 0; i < positionLibre; i++)
            {
                tab[i] = null;
            }
            positionLibre = 0;
        }

        public int NombreDElement()
        {
            return positionLibre;
        }

    }
}
