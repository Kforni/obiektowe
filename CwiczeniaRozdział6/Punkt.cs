using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Punkt
    {
        //Zad 5
        private double x;
        private double y;

        public Punkt(double x1, double y1)
        {
            x = x1;
            y = y1;
        }

        public double Get_x { get { return x; } }
        public double Get_y { get { return y; } }

        public void Przesun(double px, double py)
        {
            x += px;
            y += py;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Punkt ma wspolrzedne ({0},{1})", x, y);
        }

        //Zad 6
        public static bool Czy_na_prostej(Punkt[] punkty)
        {
            if (0 < punkty.Length && punkty.Length < 3)
            {
                return true;
            }
            else
            {
                double a, b;
                a = (punkty[0].y - punkty[1].y) / (punkty[0].x - punkty[1].x);
                b = punkty[0].y - a * punkty[0].x;
                for (int i = 2; i < punkty.Length; i++)
                {
                    if (punkty[i].y != a * punkty[i].x + b)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
