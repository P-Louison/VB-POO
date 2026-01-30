using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObjet
{
    internal class Catalogue
    {
        static void Main(string[] args)
        {
            Hashtable Catalogue = new Hashtable();
            bool continuer = true;
            double choix, pPrixHT, pTauxTVA, pourcentage;
            string pDesignation, referenceProduit;

            do
            {
                Console.WriteLine("1. Ajouter un produit au catalogue");
                Console.WriteLine("2. Augmenter le prix HT d'un produit");
                Console.WriteLine("3. Baisser le prix HT d'un produit");
                Console.WriteLine("4. Modifier le taux de TVA d'un produit");
                Console.WriteLine("5. Augmenter tous les produits du catalogue");
                Console.WriteLine("6. Supprimer un produit du catalogue");
                Console.WriteLine("7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)");
                Console.WriteLine("8. Afficher toutes les informations sur un produit (inc. Prix TTC)");
                Console.WriteLine("9. Vider le catalogue");
                Console.WriteLine("10. Quitter");


                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Quel est le nom du produit");
                        pDesignation = Console.ReadLine(); 
                        Console.WriteLine("Quel est le Prix Hors Taxe");
                        pPrixHT = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quel est le Taux de la TVA");
                        pTauxTVA = int.Parse(Console.ReadLine());
                        Produit newProduit = new Produit(pDesignation, pPrixHT, pTauxTVA);
                        Console.WriteLine("Quel est la Référence du produit dans le dictionnaire");
                        referenceProduit = Console.ReadLine();
                        Catalogue.Add(referenceProduit, newProduit);
                        break;

                    case 2 :
                        Console.WriteLine("De quel produit le prix hors Taxe doit augmenter");
                        referenceProduit = Console.ReadLine();
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            if ((string)p.Key == referenceProduit)
                            {
                                do
                                {
                                    Console.WriteLine("Quel est le nouveau pourcentage ?");
                                    pourcentage = int.Parse(Console.ReadLine());
                                }while ((pourcentage != 0) && (pourcentage < 0));
                                ((Produit)p.Value).AugmenterPrix(pourcentage);
                            }
                        }
                        break;

                    case 3 :
                        Console.WriteLine("De quel produit le prix hors Taxe doit baisser");
                        referenceProduit = Console.ReadLine();
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            if ((string)p.Key == referenceProduit)
                            {
                                do
                                {
                                    Console.WriteLine("Quel est le nouveau pourcentage ?");
                                    pourcentage = int.Parse(Console.ReadLine());
                                } while ((pourcentage != 0) && (pourcentage < 0));
                                ((Produit)p.Value).BaisserPrix(pourcentage);
                            }
                        }
                        break;

                    case 4 :
                        Console.WriteLine("De quel produit la taux de la TVA doit changer ?");
                        referenceProduit = Console.ReadLine();
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            if ((string)p.Key == referenceProduit)
                            {
                                do
                                {
                                    Console.WriteLine("Quel est le Taux ?");
                                    pourcentage = int.Parse(Console.ReadLine());
                                } while (pourcentage < 0);
                                ((Produit)p.Value).SetTauxTVA(pourcentage);
                            }
                        }
                        break;

                    case 5 :
                        do
                        {
                            Console.WriteLine("Quel est le nouveau pourcentage ?");
                            pourcentage = int.Parse(Console.ReadLine());
                        } while (pourcentage < 0);
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            ((Produit)p.Value).AugmenterPrix(pourcentage);
                        }
                        break;

                    case 6 :
                        Console.WriteLine("Quel produit doit être supprimer");
                        referenceProduit = Console.ReadLine();
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            if ((string)p.Key == referenceProduit)
                            {
                                Catalogue.Remove(p.Key);
                                break;
                            }
                        }
                        break;

                    case 7 :

                        foreach (DictionaryEntry p in Catalogue)
                        { 
                            Console.WriteLine("Clé : " + p.Key);
                            Console.WriteLine("Désignation du produit : " + ((Produit)p.Value).GetDesignation());
                            Console.WriteLine("prix hors taxe du produit : " + ((Produit)p.Value).GetPrixHT());
                            Console.WriteLine("Taux de la TVA : " + ((Produit)p.Value).GetTauxTVA());
                            Console.WriteLine("prix TTC du produit : " + ((Produit)p.Value).GetPrixTTC());
                        }

                        break;

                    case 8 :
                        Console.WriteLine("Référence du produit");
                        referenceProduit = Console.ReadLine();
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            if (((Produit)p.Value).GetDesignation() == referenceProduit)
                            {
                                Console.WriteLine("Clé : " + p.Key);
                                Console.WriteLine("Désignation du produit : " + ((Produit)p.Value).GetDesignation());
                                Console.WriteLine("prix hors taxe du produit : " + ((Produit)p.Value).GetPrixHT());
                                Console.WriteLine("Taux de la TVA : " + ((Produit)p.Value).GetTauxTVA());
                                Console.WriteLine("prix TTC du produit : " + ((Produit)p.Value).GetPrixTTC());
                                break;
                            }
                        }
                        break;

                    case 9 :
                        foreach (DictionaryEntry p in Catalogue)
                        {
                            Catalogue.Clear();
                        }
                        break;

                    case 10:
                        Console.WriteLine("au-revoir !");
                        Console.ReadLine();
                        continuer = false;
                        break;
                }
            }
            while (continuer == true);
        }
    }
}
