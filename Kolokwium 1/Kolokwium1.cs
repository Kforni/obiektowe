using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Kolokwium1
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
            Zad4();

        }

        static void Zad1()
        {
            double a,c,delta;
            Console.WriteLine("Wariant 10: Zadanie 1");
            Console.WriteLine("Rozwiązywanie równania ax^2 + 2x - 3c = 0");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("To nie jest funkcja kwadratowa");
            }
            else
            {
                delta = 2 * 2 - 4 * a * (-3 * c);
                if (delta < 0)
                    Console.WriteLine("Rozwiązanie nie ma pierwiastków w liczbach rzeczywistych");
                else if (delta == 0)
                {
                    double x = (-2) /(2 * a);
                    Console.WriteLine("Rozwiązanie ma jeden podwójny pierwiastek x={0}",x);
                }
                else
                {
                    double x1, x2;
                    x1 = (-2 - Math.Sqrt(a)) / (4 * a);
                    x2 = (-2 + Math.Sqrt(a)) / (4 * a);
                    Console.WriteLine("Równianie ma pierwiastki x1={0}, x2={1}", x1, x2);
                }
            }
            Console.ReadKey();
        }

        static int CzyToTrojkat(double a, double b, double c)
        {
            if ((a + b >= c) && (a + c >= b) && (b + c >= a)) 
                return 1;
            return 0;
        }

        static void Zad2()
        {
            double a, b, c;
            Console.WriteLine("Podaj długości trzech odcinków, sprawdzę czy tworzą trójkąt");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Odcinki nie mogą mieć ujemnej długości!");
            else
            {
                if (CzyToTrojkat(a, b, c) == 1)
                    Console.WriteLine("Odcinki o długościach {0}, {1}, {2} tworzą trójkąt", a, b, c);
                else
                    Console.WriteLine("Odcinki o długościach {0}, {1}, {2} NIE tworzą trójkąta", a, b, c);
            }
            Console.ReadKey();
        }

        static int min(int[] liczby)
        {
            int minimum = liczby[0], minimum_index=0;
            for (int i = 1; i < 10; i++)
            {
                if (liczby[i] < minimum)
                {
                    minimum = liczby[i];
                    minimum_index = i;
                }

            }
            return minimum_index;
        }

        static void Zad3()
        {
            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbę [{0}]", i);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Najmniejszy element w tablicy występuje na indexie: {0}", min(liczby));
            Console.ReadKey();
        }


        static int max_ujemna(int[] liczby)
        {
            int max = -1111, max_index = 0;
            for (int i = 1; i < 10; i++)
            {
                if ((liczby[i]<0) && (liczby[i] > max))
                {
                    max = liczby[i];
                    max_index = i;
                }
            }
            return max_index;
        }
        static void Zad4()
        {
            int[] liczby = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbę [{0}]", i);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            if (max_ujemna(liczby) != -1111)
                Console.WriteLine("Największa z liczb ujemnych występuje na pozycji: {0}", max_ujemna(liczby));
            else
                Console.WriteLine("Nie podano żadnych liczb ujemnych");
            Console.ReadKey();
        }
    }
}
