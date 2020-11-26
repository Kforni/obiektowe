using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_rozdzial_5
{
    class Cw_rozdzial_5
    {
        static void Main(string[] args)
        {
            Zad5_1();
            Zad5_2();
            Zad5_3();
            Zad5_4();
            Zad5_5();
            Zad5_6();
            Zad5_7();
            Zad5_8();
            Zad5_9();
            Zad5_10();
        }

        static double Fah_to_Cel(double Fah)
        {
            return ((Fah - 32) * (9 / 5));
        }

        static void Zad5_1()
        {
            Console.WriteLine("Zad.1 10 stopni Fahrenheita to {0} stopni Celsjusza", Fah_to_Cel(10));
            Console.ReadKey();
        }

        static bool Is_in_range(double a, double b, double x)
        {
            if (a < x && x < b) return true;
            return false;
        }

        static void Zad5_2()
        {
            double a, b, x;
            Console.WriteLine("Zad.2");
            Console.WriteLine("Podaj początek przedziału");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę do sprawdzenia przedziału");
            x = double.Parse(Console.ReadLine());
            if (a < b)
            {
                if (Is_in_range(a, b, x))
                    Console.WriteLine("Liczba {0} należy do przedziału ({1},{2})", x, a, b);
                else
                    Console.WriteLine("Liczba {0} NIE należy do przedziału ({1},{2})", x, a, b);
            }
            else
                Console.WriteLine("Niepoprawny przedział!");
            Console.ReadKey();
        }

        static void Przesun(ref double x, ref double y, double wek_x, double wek_y)
        {
            x += wek_x;
            y += wek_y;
        }

        static void Zad5_3()
        {
            double x, y;
            double wek_x = 3, wek_y = 2;
            Console.WriteLine("Zad.3");
            Console.WriteLine("Podaj pierwszą współrzędną wektora");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą współrzędną wektora");
            y = double.Parse(Console.ReadLine());
            Console.Write("Wektor ({0},{1}) po przesunięciu o wektor ({2},{3}) przechodzi na wektor ", x, y,  wek_x, wek_y);
            Przesun(ref x, ref y, wek_x, wek_y);
            Console.Write("({0},{1}) \n",x,y);
            Console.ReadKey();
        }

        static int[] Mnozenie_tablicy_1(int[] tablica, int mnoznik)
        {
            int[] wymnozona = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                wymnozona[i] = tablica[i] * mnoznik;
            }
            return wymnozona;
        }

        static void Mnozenie_tablicy_2(ref int[] tablica, int mnoznik)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] *= mnoznik;
            }
        }

        static void Zad5_4()
        {
            Console.WriteLine("Zad.4");
            int[] tab = { 1, 2, 3, 4, 5, 6 };
            int mnoznik = 2;
            Console.WriteLine("Tablica do wymnożenia:");
            for (int i =0; i<tab.Length; i++)
            {
                Console.Write(tab[i]+", ");
            }
            Console.WriteLine();
            int[] tab1 = Mnozenie_tablicy_1(tab, mnoznik);
            Console.WriteLine("Tablica po wymnożenia pierwszą metodą (nowa tablica):");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + ", ");
            }
            Console.WriteLine();
            Mnozenie_tablicy_2(ref tab, mnoznik);
            Console.WriteLine("Tablica po wymnożenia drugą metodą (przez referencję):");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Rysuj(int dl, int sz, char znak)
        {
            Console.WriteLine();
            for (int i = 0; i < sz; i++)
            {
                Console.WriteLine(new String(znak, dl));
            }
            Console.WriteLine();
            for (int i=0; i<dl; i++)
            {
                Console.WriteLine(new String(znak, sz));
            }
        }

        static void Zad5_5()
        {
            int dl, sz;
            char znak;
            Console.WriteLine("Zad.5");
            Console.WriteLine("Podaj długość");
            dl = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość");
            sz = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak");
            znak = Convert.ToChar(Console.ReadLine());
            Rysuj(dl, sz, znak);
            Console.ReadKey();
        }

        static void Mnozenie_tablicy_2(ref string[] tablica, int mnoznik)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = string.Concat(Enumerable.Repeat(tablica[i], mnoznik));
            }
        }

        static void Zad5_6()
        {
            Console.WriteLine("Zad.6");
            string[] tab = { "Ala", "Ma", "Małego", "Kotka"};
            int mnoznik = 2;
            Console.WriteLine("Tablica stringów do wymnożenia:");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
            Mnozenie_tablicy_2(ref tab, mnoznik);
            Console.WriteLine("Tablica po multiplikacji");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static int Licz_W(int x, int n)
        {
            int wynik = 0;
            for (int i = 1; i <= n; i++)
                wynik += i;
            wynik += (n * x);
            return wynik;
        }

        static void Zad5_7()
        {
            int x, n;
            Console.WriteLine("Zad.7");
            Console.WriteLine("Wyliczam wartość wyrażenia W = (x+1) + (x+2) + ... + (x+n)");
            Console.WriteLine("Podaj n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik powyższego wyrażenia dla n={0} i x={1} wynosi {2}",n,x,Licz_W(x,n));
            Console.ReadKey();
        }

        static int Licz_sume_cyfr(int liczba)
        {
            string cyfry = liczba.ToString();
            int suma=0;
            for (int i=0; i<cyfry.Length; i++)
            {
                suma += int.Parse(cyfry[i].ToString());
            }
            return suma;
        }

        static void Zad5_8()
        {
            int liczba;
            string liczba_loaded;
            Console.WriteLine("Zad.8");
            Console.WriteLine("Podaj liczbę naturalną, policzę sumę jej cyfr");
            liczba_loaded = Console.ReadLine();
            if (int.TryParse(liczba_loaded, out liczba) && liczba>0)
                Console.WriteLine("Suma cyfr liczby {0} jest równa {1}", liczba, Licz_sume_cyfr(liczba));
            else
                Console.WriteLine("To nie jest liczba naturalna!");
            Console.ReadKey();
        }

        static int Fibonacci_iteracyjnie(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                int wyraz_minus_2 = 0;
                int wyraz_minus_1 = 1;
                int wyraz=0;
                int i = 1;
                while (i < n)
                {
                    wyraz = wyraz_minus_1 + wyraz_minus_2;
                    wyraz_minus_2 = wyraz_minus_1;
                    wyraz_minus_1 = wyraz;
                    i++;
                }
                return wyraz;
            }
        }

        static int Fibonacci_rekurencyjnie(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return Fibonacci_rekurencyjnie(n - 1) + Fibonacci_rekurencyjnie(n - 2);
        }

        static void Zad5_9()
        {
            Console.WriteLine("Zad.9");
            Console.WriteLine("Podaj wyraz ciągu Fibonacciego, który chcesz poznać");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine("{0}. wyraz ciągu Fibonacciego (metoda iteracyjna): {1} ", n, Fibonacci_iteracyjnie(n));
                Console.WriteLine("{0}. wyraz ciągu Fibonacciego (rekurencyjnie): {1}", n, Fibonacci_rekurencyjnie(n));
            }
            else
                Console.WriteLine("n musi być liczbą naturalną!");
            Console.ReadKey();
        }

        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }

        static void Zad5_10()
        {
            Console.WriteLine("Zad. 10: Wynikiem będzie liczba 15. Metoda oblicz liczy sumę liczb naturalnych od 1 do n");
            Console.WriteLine(Oblicz(5));
            Console.ReadKey();
        }
    }
}
