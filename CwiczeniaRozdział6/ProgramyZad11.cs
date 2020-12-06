using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    static class ProgramyZad11
    {
        public static void Kalkulator()
        {
            double a, b, wynik = 0;
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
                    if (b == 0)
                    {
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
            if (blad == false)
                Console.WriteLine("Oto wynik dzialania: {0} {1} {2} = {3}", a, dzialanie, b, wynik);
            Console.ReadKey();
        }

        public static void BMI()
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
            else if (BMI <= 24.99)
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

        public static void Doskonale()
        {
            int n;
            string doskonale = "";
            Console.WriteLine("Podaj liczbę n. Poszukam liczb doskonałych w przedziale <1,n>");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j <= Math.Ceiling((double)i / 2); j++)
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

        public static void Przestepny()
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

        public static void Monety()
        {
            int counter = 0;
            Console.WriteLine("Na ile sposobów można rozmienić 10zł mając do dyspozycji monety 5zł, 2 zł i 1zł?");
            for (int ile5 = 2; ile5 >= 0; ile5--)
            {
                for (int ile2 = 5; ile2 >= 0; ile2--)
                {
                    for (int ile1 = 10; ile1 >= 0; ile1--)
                    {
                        if (ile5 * 5 + ile2 * 2 + ile1 == 10)
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
