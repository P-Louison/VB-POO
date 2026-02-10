using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace ADOExemples
{
    static class Program
    {
        public static void Main()
        {
            NpgsqlDataReader jeuEnr = null;
            NpgsqlConnection maCnx; // ! déclaration avant le bloc Try
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            int choix;

            do
            {
                Console.WriteLine("1. selectionner les auteurs qui commencentr par :");
                Console.WriteLine("2. ajouter un publishers (nom, adress, city, zip)");
                Console.WriteLine("3. quel titre oeuvre est a supprimmer ?");
                Console.WriteLine("4. ajouter un livre(idauteur,titre,pubid,isbn");
                Console.WriteLine("5. Quitter");

                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        try
                        {
                            string requête, nom;

                            Console.WriteLine("Quel est le début du nom ?");
                            nom = Console.ReadLine() + "%";

                            maCnx.Open(); // on se connecte
                                          // NOTA BENE AUTHOR est le nom champ (nom, prénom) et AUTHORS la table ! !
                                          // DEBUT requête paramétrée


                            requête = "Select * from publishers Where name Like @lettre";
                            var maCde = new NpgsqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@lettre", nom);
                            // FIN requête paramétrée

                            // DEBUT requête par concaténation
                            jeuEnr = maCde.ExecuteReader();
                            while (jeuEnr.Read())
                            {
                                Console.WriteLine(jeuEnr["name"] + "\t");
                            }

                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 2:
                        try
                        {
                            string requête, nom, adresse,ville,cp;
                            Console.WriteLine("Quel est son prénom, nom");
                            nom = Console.ReadLine();
                            Console.WriteLine("Quel est son adresse");
                            adresse = Console.ReadLine();
                            Console.WriteLine("Quel est sa ville");
                            ville = Console.ReadLine();
                            Console.WriteLine("Quel est son code postale");
                            cp = Console.ReadLine();


                            maCnx.Open(); // on se connecte
                                          // NOTA BENE AUTHOR est le nom champ (nom, prénom) et AUTHORS la table ! !
                                          // DEBUT requête paramétrée


                            requête = "insert into publishers (name, address, city, zip) values(@nom, @adresse, @ville, @codepostale)";
                            var maCde = new NpgsqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@nom", nom);
                            maCde.Parameters.AddWithValue("@adresse", adresse);
                            maCde.Parameters.AddWithValue("@ville", ville);
                            maCde.Parameters.AddWithValue("@codepostale", cp);
                            // FIN requête paramétrée

                            int nbLigneAffectées;
                            nbLigneAffectées = maCde.ExecuteNonQuery();
                            Console.WriteLine("Nombre de ligne affectée(s) :" + nbLigneAffectées.ToString());
                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 3:
                        try
                        {
                            string requête, requête2;
                            string ISBN;
                            Console.WriteLine("Quel est l'ISBN");
                            ISBN = (Console.ReadLine());

                            maCnx.Open(); // on se connecte
                                          // NOTA BENE AUTHOR est le nom champ (nom, prénom) et AUTHORS la table ! !
                                          // DEBUT requête paramétrée


                            requête = "Delete from titleauthor where isbn = @isbn";
                            var maCde = new NpgsqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@isbn", ISBN);
                            maCde.ExecuteNonQuery();

                            requête2 = "Delete from titles where isbn = @isbn";
                            var maCde2 = new NpgsqlCommand(requête2, maCnx);
                            maCde2.Parameters.AddWithValue("@isbn", ISBN);
                            maCde2.ExecuteNonQuery();
                            // FIN requête paramétrée

                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        try
                        {
                            string requete, isbn, titre;
                            int pubid, idauteur;
                            Console.WriteLine("Quel est son isbn");
                            isbn = Console.ReadLine();
                            Console.WriteLine("Quel est son titre");
                            titre = Console.ReadLine();
                            Console.WriteLine("Quel est son id auteur");
                            idauteur = int.Parse(Console.ReadLine());
                            Console.WriteLine("Quel est son id editeur");
                            pubid = int.Parse(Console.ReadLine());


                            maCnx.Open(); // on se connecte
                                          // NOTA BENE AUTHOR est le nom champ (nom, prénom) et AUTHORS la table ! !
                                          // DEBUT requête paramétrée


                            requete = "insert into titles(title,pubid, isbn) values (@titre,@idpubli, @isbn); insert into titleauthor(isbn, au_id) values(@isbn, @idauthor);";
                            var maCde = new NpgsqlCommand(requete, maCnx);
                            maCde.Parameters.AddWithValue("@titre", titre);
                            maCde.Parameters.AddWithValue("@idpubli", pubid);
                            maCde.Parameters.AddWithValue("@isbn", isbn);
                            maCde.Parameters.AddWithValue("@idauthor", idauteur);


                            // FIN requête paramétrée

                            int nbLigneAffectées;
                            nbLigneAffectées = maCde.ExecuteNonQuery();
                            Console.WriteLine("Nombre de ligne affectée(s) :" + nbLigneAffectées.ToString());
                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("au revoir");
                        break;

                    default:
                        Console.WriteLine("Tu t'es trompé sous merde !");
                        Console.WriteLine("_______________________________");
                        break;

                }
     
            } while (choix > 5 );
            Console.ReadLine(); 
        }
    }
}