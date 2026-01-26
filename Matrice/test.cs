using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    internal class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrice 1");
            Matrice maMatrice = new Matrice(3,0,5);
            Console.WriteLine(maMatrice.ToString());

            Console.WriteLine("Matrice 2");
            Matrice maMatrice2 = new Matrice(3, 5, 10);
            Console.WriteLine(maMatrice2.ToString());

            Console.WriteLine("Matrice 3");
            Matrice maMatrice3 = new Matrice(3, 3, 10);
            Console.WriteLine(maMatrice3.ToString());

            Console.WriteLine("produit scalaire de la 3");
            maMatrice3.MultiplicationScalaire(10);
            Console.WriteLine(maMatrice3.ToString());

            Console.WriteLine("addition de la 1 et la 2");
            Console.WriteLine((maMatrice.Addition(maMatrice2)).ToString());

            Console.WriteLine("soustraction de la 1 sur la 2");
            Console.WriteLine((maMatrice2.Soustraction(maMatrice)).ToString());

            Console.WriteLine("Transposition de la 1");
            maMatrice.Transposee();
            Console.WriteLine(maMatrice.ToString());




            Console.ReadLine();








        }
    }
}
