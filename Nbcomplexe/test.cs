using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbcomplexe
{
    internal class test
    {
        static void Main()
        {
            int choix;
            int val1, val2;
            bool continuer = true;
            Complexe[] Tab = new Complexe[10];
            int posLibre = 0;
            



            do
            {
                Console.WriteLine("1. Afficher la somme de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("2. Afficher la soustraction de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("3. Afficher le produit de deux nombres complexes saisis par l’utilisateur");
                Console.WriteLine("4. Afficher l’inverse d’un nombre complexe saisi par l’utilisateur");
                Console.WriteLine("5. Afficher le module d’un nombre complexe saisi par l’utilisateur");
                Console.WriteLine("6. Ajouter un Complexe dans un tableau");
                Console.WriteLine("7. Faire la somme des nombres complexes du tableau.");
                Console.WriteLine("8. Quitter");

                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe add1 = new Complexe(val1, val2);
                        Console.WriteLine("entrez la valeur REELLE du deuximeme NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du deuximeme NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe add2 = new Complexe(val1, val2);
                        Console.WriteLine("résultat : ");
                        Console.WriteLine(add1.addition(add2));
                        break;

                    case 2:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe sous1 = new Complexe(val1, val2);
                        Console.WriteLine("entrez la valeur REELLE du deuximeme NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du deuximeme NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe sous2 = new Complexe(val1, val2);
                        Console.WriteLine("résultat : ");
                        Console.WriteLine(sous1.soustraction(sous2));
                        break;
                    case 3:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe prod1 = new Complexe(val1, val2);
                        Console.WriteLine("entrez la valeur REELLE du deuximeme NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du deuximeme NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe prod2 = new Complexe(val1, val2);
                        Console.WriteLine("résultat : ");
                        Console.WriteLine(prod1.produit(prod2));
                        break;

                    case 4:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe inv1 = new Complexe(val1, val2);
                        Console.WriteLine(inv1.inverse());
                        break;  

                    case 5:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe mod1 = new Complexe(val1, val2);
                        Console.WriteLine("résultat : ");
                        Console.WriteLine(mod1.Getmodule());
                        break;

                    case 6:
                        Console.WriteLine("entrez la valeur REELLE du premier NB Complexe");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("entrez la valeur IMAGINAIRE du premier NB Complexe");
                        val2 = int.Parse(Console.ReadLine());
                        Complexe ajout1 = new Complexe(val1, val2);
                        Tab[posLibre] = ajout1;
                        posLibre++; 
                        break;

                    case 7:
                        Complexe somme = new Complexe();
                        for (int i = 0; i < Tab.Length; i++)
                        {
                            somme.addition(Tab[i]);
                        }
                        Console.WriteLine(somme.ToString());
                        break;

                    case 8:
                        Console.WriteLine("au-revoir !");
                        continuer = false;
                        break;

                }
                Console.ReadLine();

            }
            while (continuer != false);
            

        }
    }
}

