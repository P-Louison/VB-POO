using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class test
    {
        static void Main(string[] args)
        {
            Vehicule monVehicule = new Vehicule("VU01", "DS", 50);
            Vehicule monTourisme = new Tourisme("VU22", "Simca Aronde", 50, 5, 4, false);
            Vehicule monTourisme = new Utilitaire("VU10", "Citroën ", 50, 1000, 5, 5, 5);

        }
    }
}
