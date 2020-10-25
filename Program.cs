using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Zad1();
            Console.WriteLine("----------------------------");
            Zad2();
            Console.WriteLine("----------------------------");
            Zad3();
            Console.WriteLine("----------------------------");
            Zad4();
            Console.WriteLine("----------------------------");
            Zad5();
            Console.WriteLine("----------------------------");
            Zad6();
            Console.WriteLine("----------------------------");
            Zad7();
            Console.WriteLine("----------------------------");
            Zad8();
            Console.WriteLine("----------------------------");
            Zad9();
            Console.WriteLine("----------------------------");
            Zad10();
        }

        static void Zad1()
        {
            Console.WriteLine("Zadanie 2.1:");
            int C;
            double F;
            Console.WriteLine("Proszę podać temperaturę w stopniach Celsjusza, przeliczę je na Fahrenheity");
            C = int.Parse(Console.ReadLine());
            F = 32 + 9 / 5.0 * C;
            Console.WriteLine("{0} stopni Celsjusza, to {1} stopni Fahrenheita", C, F);
        }

        static void Zad2()
        {
            Console.WriteLine("Zadanie 2.2:");
            double a, b, c, delta;
            Console.WriteLine("Proszę podać wspołczynniki równania kwadratowego w postaci ogólnej: ax^2+bx+c=0 ");
            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = int.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Delta równania {0}x^2+{1}x+{2} jest rowna {3}",a,b,c,delta);
        }

        static void Zad3()
        {
            Console.WriteLine("Zadanie 2.3:");
            int waga;
            double wzrost, BMI;
            Console.WriteLine("Program liczy BMI na podstawie podanego wzrostu i wagi");
            Console.WriteLine("Podaj swój wzrost (w m)");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę");
            waga = int.Parse(Console.ReadLine());
            BMI = waga / Math.Pow(wzrost,2);
            Console.WriteLine("BMI dla osoby o wzroscie {0} i wadze {1} jest rowne {2}", wzrost, waga, BMI);
        }
        static void Zad4()
        {
            Console.WriteLine("Zadanie 2.4: a) wyświetli się liczba 202 ");
        }

        static void Zad5()
        {
            Console.WriteLine("Zadanie 2.5: d) zmienna x = 12.");
        }
        static void Zad6()
        {
            Console.WriteLine("Zadanie 2.6: Zmienna x przyjmie wartość 3");
        }
        
        static void Zad7()
        {
            Console.WriteLine("Zadanie 2.7: Na ekranie wyświetli się liczba 7");
        }
        static void Zad8()
        {
            Console.WriteLine("Zadanie 2.8: a) x=true, y=1, z=2 ");
        }
        static void Zad9()
        {
            Console.WriteLine("Zadanie 2.9:");
            Console.WriteLine("a) wynik=false x=2 y=4 z=2");
            Console.WriteLine("b) wynik=false x=2 y=5 z=2");
            Console.WriteLine("c) wynik=false x=2 y=5 z=1");
            Console.WriteLine("d) wynik=true x=1 y=3 z=4");
            Console.WriteLine("e) wynik=true x=1 y=4 z=4");
            Console.WriteLine("f) wynik=true x=1 y=4 z=5");
        }
        static void Zad10()
        {
            Console.WriteLine("Zadanie 2.10: Zmienna gestoscZaludnienia przyjmie wartość 0, ponieważ dzielenie wykowywane jest na liczbach typu INT. Można to poprawić rzutując jedną ze zmiennych osoby lub powierzchnia na typ DOUBLE. Wtedy druga linijka może wyglądać w ten sposób \n \"double gestoscZaludnienia = (double)osoby/powierzchnia;\"");
            Console.ReadKey();
        }
    }
}
