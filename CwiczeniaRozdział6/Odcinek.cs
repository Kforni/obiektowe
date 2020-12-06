using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Odcinek
    {
        //Zad 7
        private Punkt poczatek;
        private Punkt koniec;

        public Odcinek(Punkt p1, Punkt p2)
        {
            poczatek = p1;
            koniec = p2;
        }

        public string get_poczatek { get { return "(" + poczatek.Get_x + "," + poczatek.Get_y + ")"; } }
        public string get_koniec { get { return "(" + koniec.Get_x + "," + koniec.Get_y + ")"; } }
        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow((poczatek.Get_x - koniec.Get_x), 2) + Math.Pow((poczatek.Get_y - koniec.Get_y), 2));
        }
    }
}
