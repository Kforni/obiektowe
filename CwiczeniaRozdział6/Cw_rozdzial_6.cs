using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    class Cw_rozdzial_6
    {
        static void Main(string[] args)
        {
/*            Zad6_1();
            Zad6_2();
            Zad6_3();
            Zad6_4();
            Zad6_5();
            Zad6_6();
            Zad6_7();
            Zad6_8();
            Zad6_9();
            Zad6_10();*/
            Zad6_11();
        }

        static void Zad6_1()
        {
            Prostokat p = new Prostokat(5, 6);
            p.Prezentuj();
            Console.ReadKey();
        }

        static void Zad6_2()
        {
            Console.WriteLine("Zadanie 2");
            Prostokat[] prostokaty = new Prostokat[10];
            Random rand = new Random();
            for (int i=0; i<prostokaty.Length; i++)
            {
                prostokaty[i] = new Prostokat(rand.Next(1, 15), rand.Next(1, 15));
            }
            foreach (Prostokat prostokat in prostokaty)
            {
                prostokat.Prezentuj();
            }
            Console.ReadKey();
        }

        static void Zad6_3()
        {
            Console.WriteLine("Zadanie 3");
            Prostokat[] prostokaty = new Prostokat[10];
            Random rand = new Random();
            for (int i = 0; i < prostokaty.Length; i++)
            {
                prostokaty[i] = new Prostokat(rand.Next(1, 15), rand.Next(1, 15));
            }
            foreach (Prostokat prostokat in prostokaty)
            {
                prostokat.Prezentuj();
            }
            Console.WriteLine("Największa powierzchnia : {0}", Prostokat.Max_Powierzchnia(prostokaty));
            Console.ReadKey();
        }

        static void Zad6_4()
        {
            Console.WriteLine("Zadanie 4");
            Random rand = new Random();
            Zuzycie licznik = new Zuzycie(rand.NextDouble()*10, rand.NextDouble()*10+10);
            Console.WriteLine("Stan licznika: {0}", licznik.dane_Licznika);
            Console.WriteLine("Zużucie: {0}",licznik.zuzycie_roznica);
            Console.ReadKey();
        }

        static void Zad6_5()
        {
            Console.WriteLine("Zadanie 5");
            Punkt punkcik = new Punkt(2,3);
            punkcik.Wyswietl();
            Console.WriteLine("Przesuwany punkt o wektor (3,4)");
            punkcik.Przesun(3,4);
            punkcik.Wyswietl();
            Console.ReadKey();
        }

        static void Zad6_6()
        {
            Punkt[] punkty = new Punkt[3];
            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Sprawdzę czy podane punkty leżą na jednej prostej");
            // Punkty, które leżą na jednej prostej
            punkty[0] = new Punkt(1, 1);
            punkty[1] = new Punkt(2, 2);
            punkty[2] = new Punkt(5, 5);
            foreach(Punkt punkt in punkty)
            {
                punkt.Wyswietl();
            }
            if (Punkt.Czy_na_prostej(punkty) == true)
                Console.WriteLine("Punkty leżą na jednej prostej", punkty[0]);
            else
                Console.WriteLine("Punkty NIE leżą na jednej prostej");

            //Punkty, które NIE leżą na jednej prostej
            punkty[0] = new Punkt(1, 2);
            punkty[1] = new Punkt(2, 3);
            punkty[2] = new Punkt(5, 5);
            foreach (Punkt punkt in punkty)
            {
                punkt.Wyswietl();
            }
            if (Punkt.Czy_na_prostej(punkty) == true)
                Console.WriteLine("Punkty leżą na jednej prostej", punkty[0]);
            else
                Console.WriteLine("Punkty NIE leżą na jednej prostej");
            Console.ReadKey();
        }

        static void Zad6_7()
        {
            Console.WriteLine("Zadanie 7");
            Odcinek odcinek = new Odcinek(new Punkt(1,1), new Punkt(2,2));
            Console.WriteLine("Dlugość odcinka między punktami {1} i {2} wynosi {0}", odcinek.Dlugosc(),
                odcinek.get_poczatek, odcinek.get_koniec);
            Console.ReadKey();
        }

        static void Zad6_8()
        {
            Console.WriteLine("Zadanie 7");
            Prostopadloscian p24 = new Prostopadloscian(2, 3, 4);
            Prostopadloscian p24_2 = new Prostopadloscian(2, 2, 6);
            Prostopadloscian p100 = new Prostopadloscian(1, 1, 100);
            Console.WriteLine(Prostopadloscian.Porownaj(p24, p100));
            Console.WriteLine(Prostopadloscian.Porownaj(p24, p24_2));
            Console.ReadKey();
        }

        static void Zad6_9()
        {
            Console.WriteLine("Zadanie 9");
            SProstokat p = new SProstokat(5, 6);
            p.Prezentuj();
            SProstokat[] prostokaty = new SProstokat[10];
            Random rand = new Random();
            for (int i = 0; i < prostokaty.Length; i++)
            {
                prostokaty[i] = new SProstokat(rand.Next(1, 15), rand.Next(1, 15));
            }
            foreach (SProstokat prostokat in prostokaty)
            {
                prostokat.Prezentuj();
            }
            Console.ReadKey();
        }

        static void Zad6_10()
        {
            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Kandydaci na studia i ich liczba punktów");
            KandydatNaStudia[] kandydaci = new KandydatNaStudia[5];
            kandydaci[0] = new KandydatNaStudia("Nowak", 44, 64, 56);
            kandydaci[1] = new KandydatNaStudia("Szatan", 66, 66, 66);
            kandydaci[2] = new KandydatNaStudia("Prymus", 90, 97, 99);
            kandydaci[3] = new KandydatNaStudia("Nieuk", 20, 31, 7);
            kandydaci[4] = new KandydatNaStudia("Gonzales", 56, 67, 100);
            foreach (KandydatNaStudia kandydat in kandydaci)
            {
                Console.WriteLine("{0,15} - {1}", kandydat.nazwisko, kandydat.LiczPunkty());
            }
            Console.ReadKey();
        }

        static void Zad6_11()
        {
            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Za chwilę nastąpi wyświetlenie menu dla zadania 11");
            System.Threading.Thread.Sleep(5000);
            Menu.StartMenu();
        }
    }
}
