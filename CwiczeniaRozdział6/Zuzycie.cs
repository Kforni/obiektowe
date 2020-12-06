using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Zuzycie
    {
        //Zad 4
        private double zuzycie_poczatkowe;
        private double zuzycie_koncowe;

        public Zuzycie(double a, double b)
        {
            zuzycie_poczatkowe = a;
            zuzycie_koncowe = b;
        }

        public string dane_Licznika { get { return "Poczatek: " + zuzycie_poczatkowe + " Koniec: " + zuzycie_koncowe; } }

        public double zuzycie_roznica { get { return zuzycie_koncowe - zuzycie_poczatkowe; } }
    }
}
