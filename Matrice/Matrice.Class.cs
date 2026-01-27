using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Matrice
{
    internal class Matrice
    {
        private int[,] TabMatrice;
        private int ordre;
        

        public Matrice(int pOrdre, int pMin, int pMax)
        {
            Random rand = new Random();
            ordre = pOrdre;
            TabMatrice = new int[ordre, ordre];
            for (int i = 0; i < ordre; i++)
            {
                for (int j = 0; j < ordre; j++)
                { 
                    TabMatrice[i,j] = rand.Next(pMin, pMax);
                }
            }
        }

        public Matrice(int[,] tabMatrice)
        {
            TabMatrice = tabMatrice;
            ordre = TabMatrice.GetLength(1);
        }

        private int GetOrdre()
        {
            return ordre;
        }
            

        public Matrice Addition(Matrice m)
        {
            if (m.GetOrdre() == ordre)
            {
                int[,] total = new int[ordre, ordre];
                for (int i = 0; i < ordre; i++)
                {
                    for (int j = 0; j < ordre; j++)
                    {
                        total[i, j] = TabMatrice[i, j] + m.TabMatrice[i, j];
                    }
                }
                return new Matrice(total);
            }
            else
            {
                return null;
            }
        }

        public Matrice Soustraction(Matrice m)
        {
            if (m.GetOrdre() == ordre)
            {
                int[,] total = new int[ordre, ordre];
                for (int i = 0; i < ordre; i++)
                {
                    for (int j = 0; j < ordre; j++)
                    {
                        total[i,j] = TabMatrice[i, j] - m.TabMatrice[i, j];
                    }
                }
                return new Matrice(total);
            }
            else
            {
                return null;
            }
        }

        public Matrice MultiplicationScalaire(int pValeur)
        {

            int[,] result = new int[ordre, ordre];

            for (int i = 0; i < ordre; i++)
            {
                for (int j = 0; j < ordre; j++)
                {
                    result[i, j] = TabMatrice[i, j] * pValeur ;
                }
            }
            return new Matrice(TabMatrice); 

        }

        public Matrice Multiplication(Matrice m)
        {
            if (m.GetOrdre() == ordre)
            {
                int[,] total = new int[ordre, ordre];

                for (int i = 0; i < ordre; i++)
                {
                    for (int j = 0; j < ordre; j++)
                    {
                        for (int k = 0; k < ordre; k++)
                        {
                            total[i, j] += TabMatrice[i, k] * m.TabMatrice[k, j];
                        }
                    }  
                }
                return new Matrice(total);
            }
            else
            {
                return null;
            }
        }
        public void Transposee()
        {
            int val = 0;
            for (int i = 0;i < ordre; i++)
            {
                for (int j = val; j < ordre; j++)
                {
                    int[] tempo = Echanger(TabMatrice[i, j], TabMatrice[j, i]);
                    TabMatrice[i, j] = tempo[0];
                    TabMatrice[j, i] = tempo[1];
                }
                val += 1;
            }
        }

        private int[] Echanger(int val1, int val2)
        {

            int[] monTableau = new int[2];

            int val0 = 0;
            val0 = val1;
            val1 = val2;
            val2 = val0;
            monTableau[0] = val1;
            monTableau[1] = val2;
            return monTableau;
        }

        public override string ToString()
        {
            string chaine = string.Empty;
            int i = 0;
            for (i = 0; i < ordre; i++)
            {
                chaine += "[ ";
                for (int j = 0; j < ordre; j++)
                {
                    chaine += TabMatrice[i, j] + " ";
                }
                chaine += "]" + "\n";
            }
            return chaine;
        }
    }
}
