using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nbcomplexe
{
    public class Complexe
    {
        private double x;
        private double y;

        public Complexe(double nouvX, double nouvY)
        {
            x = nouvX;
            y = nouvY;
        }
        public Complexe()
        {
            x = 0;
            y = 0;
        }

        public double getReel() 
        { 
            return x; 
        }

        public double getpartielle() 
        { 
            return y; 
        }

        public Complexe addition(Complexe nombre)
        {
            Complexe result = new Complexe(x + nombre.getReel(), y + nombre.getpartielle());
            return result;
        }
        public Complexe soustraction(Complexe nombre)
        {
            Complexe result = new Complexe(x - nombre.getReel(), y - nombre.getpartielle());
            return result;
        }
        public Complexe produit(Complexe nombre)
        {
            Complexe result = new Complexe((x*nombre.getReel()) - (y*nombre.getpartielle()), (x*nombre.getpartielle()) + (nombre.getReel()*y));
            return result; 
        }
        public Complexe inverse()
        {
            Complexe result = new Complexe(x/(x*x+y*y), -y/(x*x + y*y));
            return result;
        }
        public double Getmodule()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public override string ToString()
        {
            string chaine = string.Empty;
            chaine = "partie Reelle : " + x.ToString() + "\nPartie Imaginaire : " + y.ToString();
            return chaine;
        }
            


    }
}
