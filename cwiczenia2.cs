using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia2
{
    class cwiczenia2
    {
        static void Main(string[] args)
        {
            zad3_1();
            zad3_2();
            zad3_3();
            zad3_4();
            zad3_5();
            zad3_6();
            zad3_7();
            zad3_8();
            zad3_9();
            zad3_10();
            zad3_11();
            zad3_12();
            zad3_13();
            zad3_14();
            zad3_15();
        }

        static void zad3_1()
        {
            int rok;
            Console.WriteLine("Podaj rok, powiem Ci czy jest on przestępny");
            rok = int.Parse(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                Console.WriteLine("Rok jest przestępny");
            else
                Console.WriteLine("Rok nie jest przestępny");
            Console.ReadKey();
        }

        static void zad3_2()
        {
            int liczba1, liczba2;
            Console.WriteLine("Podaj dwie liczby calkowite. Powiem Ci, czy druga jest dzielnikiem pierwszej.");
            Console.WriteLine("Podaj pierwszą liczbę");
            liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj podaj drugą liczbę");
            liczba2 = int.Parse(Console.ReadLine());
            if (liczba1 % liczba2 == 0)
                Console.WriteLine("Liczba {0} jest dzielnikiem {1}",liczba2, liczba1);
            else
                Console.WriteLine("Liczba {0} NIE jest dzielnikiem {1}", liczba2, liczba1);
            Console.ReadKey();
        }

        static void zad3_3()
        {
            int liczba, max = 0, ile_liczb = 3;
            string liczby = "";
            Console.WriteLine("Podaj {0} liczby. Powiem Ci, która jest największa", ile_liczb);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj liczbę");
                liczba = int.Parse(Console.ReadLine());
                liczby += liczba + ", ";
                if (liczba > max)
                {
                    max = liczba;
                }
            }
            Console.WriteLine("Spośród liczb {0} największa jest {1}", liczby, max);
            Console.ReadKey();
        }

        static void zad3_4()
        {
            double a, b, wynik=0;
            string dzialanie;
            bool blad = false;
            Console.WriteLine("Oto prosty kalkulator.");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz dzialanie (+, -, *, /)");
            dzialanie = Console.ReadLine();
            switch (dzialanie)
            {
                case "+":
                    wynik = a + b;
                    break;
                case "-":
                    wynik = a - b;
                    break;
                case "*":
                    wynik = a * b;
                    break;
                case "/":
                    if (b == 0) { 
                        blad = true;
                        Console.WriteLine("Błąd dzielenia przez 0");
                    }
                    else
                        wynik = a / b;
                    break;
                default:
                    blad = true;
                    Console.WriteLine("Wybrano niepoprawne działanie");
                    break;
            }
            if(blad==false)
                Console.WriteLine("Oto wynik dzialania: {0} {1} {2} = {3}",a,dzialanie,b,wynik);
            Console.ReadKey();
        }
        static void zad3_5()
        {
            double A, B, C;
            Console.WriteLine("Program liczący ilość pierwiastków równania kwadratowego postaci Ax^2 + Bx + C = 0");
            Console.WriteLine("Podaj A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj C");
            C = double.Parse(Console.ReadLine());

            if (A == 0)
                Console.WriteLine("To nie jest równanie kwadratowe!");
            else
            {
                double delta;
                delta = B * B - 4 * A * C;
                if (delta < 0)
                    Console.WriteLine("Równanie ma 0 pieriastków");
                else if (delta == 0)
                    Console.WriteLine("Równanie ma 1 pierwiastek");
                else
                    Console.WriteLine("Rówananie ma 2 pierwiastki");
            }
            Console.ReadKey();
        }

        static void zad3_6()
        {
            int waga;
            double wzrost, BMI;
            Console.WriteLine("Program liczy BMI na podstawie podanego wzrostu i wagi");
            Console.WriteLine("Podaj swój wzrost (w m)");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę");
            waga = int.Parse(Console.ReadLine());
            BMI = waga / Math.Pow(wzrost, 2);
            Console.WriteLine("BMI dla osoby o wzroscie {0} i wadze {1} jest rowne {2}", wzrost, waga, BMI);

            string podpunkt_a = "a) BMI wskazuje na";
            if (BMI < 18.5)
                Console.WriteLine(podpunkt_a + " niedowagę");
            else if(BMI <= 24.99)
                Console.WriteLine(podpunkt_a + " prawidłową wagę");
            else
                Console.WriteLine(podpunkt_a + " nadwagę");

            string podpunkt_b = "b) Rozszerzona kwalifikacja BMI wskazuje na";
            if (BMI < 16)
                Console.WriteLine(podpunkt_b + " wygłodzenie");
            else if (BMI < 17)
                Console.WriteLine(podpunkt_b + " wychudzenie");
            else if (BMI < 18.5)
                Console.WriteLine(podpunkt_b + " niedowagę");
            else if (BMI < 25)
                Console.WriteLine(podpunkt_b + " pożądaną masę ciała");
            else if (BMI < 30)
                Console.WriteLine(podpunkt_b + " nadwagę");
            else if (BMI < 35)
                Console.WriteLine(podpunkt_b + " otyłość I stopnia");
            else if (BMI < 40)
                Console.WriteLine(podpunkt_b + " otyłość II stopnia (dużą)");
            else
                Console.WriteLine(podpunkt_b + " otyłość III stopnia (chorobliwą)");
            Console.ReadKey();
        }

        static void zad3_7()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer) {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2": 
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
            Console.ReadKey();

        }

        static void zad3_8()
        {
            double srednia;
            Console.WriteLine("Podaj mi wartość średniej ocen. Powiem Ci, jaka kwota stypendium Ci przysługuje");
            srednia = double.Parse(Console.ReadLine());
            if (srednia < 4)
                Console.WriteLine("Niestety, nie przysługuje Ci stypendium");
            else if (srednia < 4.8)
                Console.WriteLine("Przysługuje Ci stypendium w kwocie 350,00 zł");
            else
                Console.WriteLine("Przysługuje Ci stypendiumw  kwocie 550,00 zł");
            Console.ReadKey();
        }

        static void zad3_9()
        {
            int ile;
            Console.WriteLine("Narysuję 4 fajne figury. Podaj ilość wierszy każdej z nich");
            ile = int.Parse(Console.ReadLine());
            //Figura 1
            Console.WriteLine("Wariant a");
            for (int i = 1; i < ile + 1; i++)
                Console.WriteLine(new String('*', i));
            //Figura 2
            Console.WriteLine("Wariant b");
            for (int i=ile; i>0; i--)
            {
                Console.WriteLine(new String('*', i));
            }
            //Figura 3
            Console.WriteLine("Wariant c");
            for (int i = 1; i < ile + 1; i++)
            {
                Console.WriteLine("{0,20}",new String('*', i));
            }
            //Figura 4
            Console.WriteLine("Wariant d");
            Console.WriteLine(new String('*', ile));
            for(int i=1; i<ile-1; i++)
            {
                Console.WriteLine("*" + new String(' ', ile-2) + "*");
            }
            Console.WriteLine(new String('*', ile));

            Console.ReadKey();
        }

        static void zad3_10()
        {
            int n, wynik = 1;
            Console.WriteLine("Program liczący silnię");
            Console.WriteLine("Podaj n całkowite większe lub równe 0");
            n = int.Parse(Console.ReadLine());
            if (n >= 0 )
            {
                for (int i = 1; i <= n; i++)
                    wynik = wynik * i;
                Console.WriteLine("{0}! = {1}", n, wynik);
            }
            else
                Console.WriteLine("Silnia niezdefiniowana dla podanej liczby");
            Console.ReadKey();
        }

        static void zad3_11()
        {
            Console.WriteLine("Ile kolejnych liczb całkowitych zaczynając od 1 należy do siebie dodać, aby taka suma była większa od 100?");
            int counter = 0;
            int suma = 0;
            int liczba = 1;
            while (suma<100)
            {
                counter++;
                suma = suma + liczba;
                liczba++;
            }
            Console.WriteLine("Potrzeba {0} takich liczb", counter);
            Console.ReadKey();
        }
        static void zad3_12()
        {
            int liczba, suma=0;
            Console.WriteLine("Proszę wpisywać liczby całkowite, ja je zsumuję. Zakończenie sumowania nastąpi ppo wprowadzeniu 0");

            do{
                liczba = int.Parse(Console.ReadLine());
                suma += liczba;
            } 
            while (liczba != 0);
            Console.WriteLine("Suma Twoich liczba to: {0}", suma);
            Console.ReadKey();
        }

        static void zad3_13()
        {
            int n, suma=0;
            Console.WriteLine("Podaj n, a policzę szereg postaci W(n)=1 - 2 + 3 - 4 + ... +- n");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i=i+2)
            {
                suma += i;
            }
            for (int i = 0; i <= n; i = i + 2)
            {
                suma -= i;
            }
            Console.WriteLine("W({0}) = {1}", n, suma);
            Console.ReadKey();
        }

        static void zad3_14()
        {
            int n;
            string doskonale="";
            Console.WriteLine("Podaj liczbę n. Poszukam liczb doskonałych w przedziale <1,n>");
            n = int.Parse(Console.ReadLine());
            for (int i=2; i <= n; i++)
            {
                int suma = 0;
                for(int j=1; j<=Math.Ceiling((double)i/2); j++)
                {
                    if (i % j == 0)
                    {
                        suma += j;
                    }
                }
                if (i == suma)
                {
                    doskonale = doskonale + i + ", ";
                }
            }
            Console.WriteLine("Liczby doskonałe z przedziału <1,{0}>, to {1}", n, doskonale);
            Console.ReadKey();
        }

        static void zad3_15()
        {
            int counter = 0;
            Console.WriteLine("Na ile sposobów można rozmienić 10zł mając do dyspozycji monety 5zł, 2 zł i 1zł?");
            for (int ile5=2; ile5>=0; ile5--)
            {
                for (int ile2=5; ile2>=0; ile2--)
                {
                    for(int ile1=10; ile1>=0; ile1--)
                    {
                        if (ile5 * 5 + ile2 * 2 + ile1  == 10)
                        {
                            counter++;
                            Console.WriteLine(counter + " sposób: {0}*5 + {1}*2 +{2}*1", ile5, ile2, ile1);
                        }
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
