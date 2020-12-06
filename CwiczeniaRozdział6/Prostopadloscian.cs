using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Prostopadloscian
    {
        //Zad 8
        private double dlugosc;
        private double szerokosc;
        private double wysokosc;

        public Prostopadloscian(double a, double b, double c)
        {
            dlugosc = a;
            szerokosc = b;
            wysokosc = c;
        }

        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }

        public string Wyswietl()
        {
            return String.Format("Prostopadloscian ({0},{1},{2})", dlugosc, szerokosc, wysokosc);
        }

        public static string Porownaj(Prostopadloscian a, Prostopadloscian b)
        {
            Console.WriteLine("Porównanie {0} z {1}", a.Wyswietl(), b.Wyswietl());
            if (a.Objetosc() > b.Objetosc())
                return "Pierwszy prostopadłościan ma większa objętość";
            else if (a.Objetosc() < b.Objetosc())
                return "Drugi prostopadłościan ma większa objętość";
            else
                return "Prostopadłościany mają taką samą objętość";
        }
    }
}
