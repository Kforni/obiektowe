using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    struct SProstokat
    {
        //Zad 9
        int dlugosc;
        int szerokosc;

        public SProstokat(int a, int b)
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
    }
}
