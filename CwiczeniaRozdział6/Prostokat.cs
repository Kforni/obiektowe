using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Prostokat
    {
        //Zad 1,2
        private int dlugosc;
        private int szerokosc;

        public Prostokat(int a, int b)
        {
            dlugosc = a;
            szerokosc = b;
        }

        private int powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private int obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public void Prezentuj()
        {
            Console.WriteLine("Pole prostokąta o wymiarach {0}x{1} wynosi {2}", dlugosc, szerokosc, powierzchnia());
            Console.WriteLine("Obówd prostokąta o wymiarach {0}x{1} wynosi {2}", dlugosc, szerokosc, obwod());
        }

        //Zad 3
        public static int Max_Powierzchnia(Prostokat[] prostokaty)
        {
            int max = 0;
            foreach (Prostokat prostokat in prostokaty)
            {
                if (prostokat.powierzchnia() > max)
                    max = prostokat.powierzchnia();
            }
            return max;
        }
    }
}
