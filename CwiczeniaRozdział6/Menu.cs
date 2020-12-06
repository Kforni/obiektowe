using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwiczeniaRozdział6
{
    static class Menu
    {
        public static void StartMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(">>>> MENU <<<<");
                Console.WriteLine("1 - Kalkulator");
                Console.WriteLine("2 - Rok przestępny");
                Console.WriteLine("3 - 10zł w monetach");
                Console.WriteLine("4 - BMI");
                Console.WriteLine("5 - Liczby doskonałe");
                Console.WriteLine("0 - KONIEC");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        ProgramyZad11.Kalkulator();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        ProgramyZad11.Przestepny();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        ProgramyZad11.Monety();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        ProgramyZad11.BMI();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        ProgramyZad11.Doskonale();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
