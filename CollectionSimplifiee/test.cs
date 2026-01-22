using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CollectionSimplifiee.Collection;

namespace CollectionSimplifiee
{
    internal class test
    {
        static void Main()
        {
            int choix;
            string cle;
            object valeur;
            bool continuer = true;

            Collection maCollection = new Collection();

            maCollection.Ajouter("22", "Côte d'Armor");
            maCollection.Ajouter("29", "Finistère");
            maCollection.Ajouter("35", "Iles et Vilaine");
            maCollection.Ajouter("56", "Morbihan");

            do
            {
                Console.WriteLine("1. Ajouter un élément");
                Console.WriteLine("2. Retourner la valeur");
                Console.WriteLine("3. Supprimer un élément");
                Console.WriteLine("4. Il existe ?");
                Console.WriteLine("5. Vider");
                Console.WriteLine("6. Nombre d'élément");
                Console.WriteLine("7. Affiche le tableau");
                Console.WriteLine("8. Quitter");

                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("entrez la cle");
                        cle = Console.ReadLine();
                        Console.WriteLine("entrez la valeur de la clé");
                        valeur = Console.ReadLine();
                        Console.WriteLine(maCollection.Ajouter(cle, valeur));
                        break;

                    case 2:
                        Console.WriteLine("entrez la cle que vous souhaitez");
                        cle = Console.ReadLine();
                        Console.WriteLine(maCollection.Retourner(cle));

                        break;
                    case 3:
                        Console.WriteLine("entrez la cle que vous souhaitez");
                        cle = Console.ReadLine();
                        Console.WriteLine(maCollection.Supprimer(cle));
                        break;

                    case 4:
                        Console.WriteLine("entrez la cle que vous souhaitez");
                        cle = Console.ReadLine();
                        Console.WriteLine(maCollection.Existe(cle));
                        break;

                    case 5:
                        maCollection.Vider();
                        break;

                    case 6:
                        Console.WriteLine(maCollection.NombreDElement());
                        break;

                    case 7:
                        Console.WriteLine(maCollection.ToString());
                        break;

                    case 8:
                        Console.WriteLine("au revoir !");
                        continuer = false;
                        break;

                }
                Console.ReadLine();

            }
            while (continuer != false);








        }
    }
}


