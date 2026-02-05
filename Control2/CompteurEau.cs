using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control2
{
    internal class CompteurEau
    {
        private string numeroserie;
        private double indexM3;
        private const double PRIXM3;

        public CompteurEau(string nouvnumeroserie)
        {
            numeroserie = nouvnumeroserie;
        }

        public string Getnumero() { return numeroserie; }

        public double GetindexM3() { return indexM3; }

        public bool SetPRIXM3(double valeur)
        {
            PRIXM3 = valeur;
        }




    }
}
