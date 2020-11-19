using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_rozdzial_4
{
    class cw_rozdzial_4
    {
        static void Main(string[] args)
        {
            zad4_1();
            zad4_2();
            zad4_3();
            zad4_4();
            zad4_5();
            zad4_6();
            zad4_7();
            zad4_8();
            zad4_9();
            zad4_10();
            zad4_11();
            zad4_12();
            zad4_13();
            zad4_14();
            zad4_15();
        }

        static void zad4_1()
        {
            Console.WriteLine("Zad 1");
            int n;
            Console.WriteLine("Podaj ile liczb chcesz wpisać do tablicy");
            n = int.Parse(Console.ReadLine());
            int[] tablica = new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Podaj liczbę");
                tablica[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Oto wpisane wartości:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(tablica[i]);
            Console.ReadKey();
        }

        static void zad4_2()
        {
            Console.WriteLine("Zad 2");
            Console.WriteLine("Ten program przepisze wartości dodatnie z jednej tablicy do drugiej");
            int[] tab1 = { 1, -2, 3, -4, 5, -6, 7, 0, 9, -123 };
            int[] tab2 = new int[10];
            int licznik_tab2 = 0;
            for(int i=0; i<tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[licznik_tab2]=tab1[i];
                    licznik_tab2++;
                }
            }
            Console.WriteLine("Tablica tab1:");
            foreach(int x in tab1)
                Console.WriteLine(x);
            Console.WriteLine("Przepisane elementy dodatnie:");
            for (int i=0; i<licznik_tab2; i++)
                Console.WriteLine(tab2[i]);
            Console.ReadKey();
        }

        static void zad4_3()
        {
            Console.WriteLine("Zad 3");
            int n;
            Console.WriteLine("Podaj ile liczb chcesz wpisać do tablicy");
            n = int.Parse(Console.ReadLine());
            int[] tablica = new int[n];
            int[] max = new int[2];
            int[] min = new int[2];
            int suma = 0, counter_dodatnie = 0;
            double srednia;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę");
                int liczba; 
                liczba = int.Parse(Console.ReadLine());
                tablica[i] = liczba;
                if (liczba > 0)
                    counter_dodatnie++;
                suma += liczba;
            }
            int j = 0;
            max[0] = min[0] = 0;
            max[1] = min[1] = tablica[0];
            do
            {
                if (tablica[j] > max[1])
                {
                    max[1] = tablica[j];
                    max[0] = j;
                }
                if (tablica[j] < min[1])
                {
                    min[1] = tablica[j];
                    min[0] = j;
                }
                j++;
            }
            while (j < tablica.Length);
            srednia = (double)suma / n;
            Console.WriteLine("Największy element: {0} na pozycji {1}", max[1], max[0]);
            Console.WriteLine("Najmniejszy element: {0} na pozycji {1}", min[1], min[0]);
            Console.WriteLine("Średnia wartość wszystkich liczb: {0}", srednia);
            Console.WriteLine("Dodatnich elementów: {0}",counter_dodatnie);
            Console.ReadKey();
        }

        static void zad4_4()
        {
            Console.WriteLine("Zad 4");
            Console.WriteLine("Wylosuję 100 liczb i sprawdzę ile jest liczb pierwszych wśród nich");
            Random rand = new Random();
            int[] liczby = new int[100];
            int[] pierwsze = new int[100];
            int counter_pierwsze = 0;
            for (int i = 0; i < 100; i++)
            {
                int liczba = rand.Next(1, 1000);
                liczby[i] = liczba;
                int counter_dzielniki = 0;
                for(int j=2; j <= Math.Ceiling((double)liczba / 2); j++)
                {
                    if (liczba % j == 0)
                        counter_dzielniki++;
                }
                if(counter_dzielniki == 0)
                {
                    pierwsze[counter_pierwsze] = liczba;
                    counter_pierwsze++;
                }
                Console.Write("{0,8}", liczba);
            }
            if (counter_pierwsze > 0)
            {
                for (int i = 0; i < counter_pierwsze; i++)
                    Console.WriteLine("Znaleziono! {0}", pierwsze[i]);
            }
            else
                Console.WriteLine("Brak liczb pierwszych wśród wylosowanych liczb");
            Console.ReadKey();
        }

        static void zad4_5()
        {
            Console.WriteLine("Zad 5");
            Console.WriteLine("Przepiszę wartości z jednej tablicy do drugiej, z przesunięciem o jeden w prawo");
            Console.WriteLine("Podaj rozmiar tych tablic");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[n];
            for (int i=0; i<n; i++)
                tab1[i] = i;
            for(int i=0; i<n-1; i++)
                tab2[i+1] = tab1[i];
            tab2[0] = tab1[n - 1];
            Console.WriteLine("Tablica 1:");
            foreach(int x in tab1)
                Console.Write("{0,8}", x);
            Console.WriteLine("\n Tablica 2:");
            foreach (int x in tab2)
                Console.Write("{0,8}", x);
            Console.ReadKey();
        }

        static void zad4_6()
        {
            Console.WriteLine("Zad 6");
            Console.WriteLine("Oto tablica 5x5:");
            int przekatna = 0, n = 5;
            int[,] tablica = new int[n, n];
            Random rand = new Random();
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    tablica[i, j] = rand.Next(1, 50);
                    if (i == j)
                        przekatna += tablica[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,5}", tablica[i,j]);
                Console.Write("\n");
            }
            Console.WriteLine("Suma wyrazów na głownej przekątnej: {0}", przekatna);
            Console.ReadKey();
        }
        static void zad4_7()
        {
            Console.WriteLine("Zad 7");
            Console.WriteLine("Dodawanie dwóch macierzy o wymiarach 2x3:");
            int[,] mac1 = { { 2, 3, 3 },{ 2, 3, 4 } };
            int[,] mac2 = { { 7, 2, 3 },{ 8, 4, 1 } };
            int[,] wynik = new int[2, 3];

            for(int i=0; i<2; i++)
            {
                for (int j=0; j<3; j++)
                    wynik[i, j] = mac1[i, j] + mac2[i, j];
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", mac1[i,j]);
                Console.Write("\n");
            }
            Console.WriteLine("+");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", mac2[i, j]);
                Console.Write("\n");
            }
            Console.WriteLine("=");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", wynik[i, j]);
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        static void zad4_8()
        {
            Console.WriteLine("Zad 8");
            Console.WriteLine("Dni tygodnia w innych językach:");
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[2, 0] = "środa";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[4, 0] = "piątek";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 2] = "sonntag";
            Console.Write("{0,20}{1,20}{2,20}\n","polski","angielski","niemiecki");
            for(int i=0; i<7; i++)
            {
                for(int j=0; j<3; j++)
                    Console.Write("{0,20}", dniTygodnia[i,j]);
                Console.Write("\n");
            }
            Console.ReadKey();
        }

        static void zad4_9()
        {
            Console.WriteLine("Zad 9");
            Console.WriteLine("Proszę wpisać jakieś zdanie, policzę ile ma wyrazów");
            string zdanie = Console.ReadLine();
            int counter = 1;
            for(int i=0; i<zdanie.Length; i++)
            {
                if(zdanie[i] == ' ')
                    counter++;
            }
            Console.WriteLine("Według moich obliczeń, wpisano {0} wyrazów", counter);
            Console.ReadKey();
        }

        static void zad4_10()
        {
            Console.WriteLine("Zad 10");
            Console.WriteLine("Proszę podać datę w formacie DD-MM-YYYY");
            string data;
            int miesiac;
            string[] miesiace = {"Styczeń", "Luty", "Marze", "Kwiecień", "Maj", "Czerwiec", "Lipiec",
                "Sierpień","Wrzesień", "Październik", "Listopad", "Grudzień" };
            do
            {
                data = Console.ReadLine();
                miesiac = int.Parse(data.Substring(3, 2));
                if (data.Length != 10 || miesiac < 1 || miesiac > 12)
                {
                    Console.WriteLine("Niepoprawna data. Proszę wpisać jeszcze raz.");
                }
            } 
            while (data.Length != 10 || miesiac < 1 || miesiac > 12);
            Console.WriteLine("Miesiac w wybranej dacie to: {0}", miesiace[miesiac-1]);
            Console.ReadKey();
        }

        static void zad4_11()
        {
            Console.WriteLine("Zad 11");
            Console.WriteLine("Wprowadź łańcuch znaków. Sprawdzę częstotliwość występowania w nim każdego znaku");
            string zdanie = Console.ReadLine();
            char[] znaki = new char[zdanie.Length];
            int counter = 0;
            int[] zliczenia = new int[zdanie.Length];
            for(int i=0; i<zdanie.Length; i++)
            {
                if (!znaki.Contains(Char.ToLower(zdanie[i])))
                {
                    znaki[counter] = Char.ToLower(zdanie[i]);
                    zliczenia[counter] = 1;
                    counter++;
                }
                else
                {
                    int index =  Array.IndexOf(znaki, Char.ToLower(zdanie[i]));
                    zliczenia[index]++;
                }
            }
            Console.WriteLine("Wystąpienia: ");
            for(int i=0; i<counter; i++)
                Console.Write("{0} - {1,-5}", znaki[i], zliczenia[i]);
            Console.ReadKey();
        }

        static void zad4_12()
        {
            Console.WriteLine("Zad 12");
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                             "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                             "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                             "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                             "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            int[] wiersze = new int[1];
            int start =0, pozycja, pozycja_start=0;
            while ((pozycja = tekst.IndexOf("\n", start)) >= 0)
            {
                int new_size = wiersze.Length + 1; 
                Array.Resize(ref wiersze, new_size);
                wiersze[new_size - 2] = pozycja - pozycja_start -2;
                pozycja_start = pozycja;
                start = pozycja + 2;
            }
            wiersze[wiersze.Length - 1] = tekst.Length - pozycja_start;
            Console.Write(tekst);
            Console.WriteLine("\n\n Wierszy: {0}", wiersze.Length);
            for(int i=0; i<wiersze.Length; i++)
                Console.WriteLine("Wiersz {0} zawiera {1} znaków", i+1, wiersze[i]);
            Console.WriteLine(tekst.Length);
            Console.ReadKey();
        }

        static void zad4_13()
        {
            Console.WriteLine("Zad 13");
            Console.WriteLine("Wprowadź łańcuch znaków. Sprawdzę częstotliwość występowania w nim słów. Po wpisaniu \"default\" użyję domyślnego zdania");
            string zdanie_in = Console.ReadLine();
            string zdanie = zdanie_in;
            if (zdanie_in == "default")
                zdanie = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            var slowa = new Dictionary<string, int>();
            int start = 0, stop, last_index = 0;
            while ((stop = zdanie.IndexOf(' ', start)) >= 0)
            {
                string wyraz = zdanie.Substring(start, stop - start).ToLower();
                wyraz = wyraz.Trim(new Char[] { ',', '*', '.', '-'});
                Console.WriteLine(wyraz);
                if(slowa.ContainsKey(wyraz))
                    slowa[wyraz]++;
                else
                    slowa.Add(wyraz, 1);
                start = stop + 1;
                last_index = stop;
            }
            string ostatnie = zdanie.Substring(last_index + 1, zdanie.Length - last_index -1).ToLower().Trim(new Char[] { ',', '*', '.', '-' });
            Console.WriteLine(ostatnie);
            if (slowa.ContainsKey(ostatnie))
                slowa[ostatnie]++;
            else
                slowa.Add(ostatnie, 1);
            start = stop + 1;
            Console.WriteLine("Wielokrotne wystąpienia w zdaniu: \"{0}\"",zdanie);
            foreach (var slowo in slowa)
            {
                if (slowo.Value > 1)
                    Console.WriteLine("{0} - {1,-5}", slowo.Key, slowo.Value);
            }
            Console.ReadKey();
        }

        static void zad4_14()
        {
            Console.WriteLine("Zad 14");
            Console.WriteLine("Program liczący czas posiadania środków trwałych");
            string[] srodki = { "PHP-2010", "CS-1996", "PYTHON-2018", "YII-1934", "SIPLAS-2003" };
            int current_year = int.Parse(DateTime.Now.ToString("yyyy"));
            foreach (string srodek in srodki)
            {
                int ile_lat = current_year - int.Parse(srodek.Substring(srodek.IndexOf('-')+1,4));
                Console.WriteLine("Srodek {0} kupiono {1} lat(a) temu", srodek, ile_lat);
            }
            Console.ReadKey();
        }

        static void zad4_15()
        {
            Console.WriteLine("Zad 15");
            Console.WriteLine("Program szyfrujący \"GA-DE-RY-PO-LU-KI\"");
            Console.WriteLine("Proszę podać własny klucz lub nacisnąć ENTER w celu użycia domyślnego");
            bool blad = false;
            string klucz;
            do
            {
                if (blad == true)
                    Console.WriteLine("Niepoprawny klucz. Proszę wpisać parzystą liczbę znaków, bez powtórek.");
                blad = false;
                klucz = Console.ReadLine().Replace("-", "");
                if (klucz.Length % 2 != 0)
                    blad = true;
                else
                {
                    foreach (char letter in klucz)
                    {
                        if (klucz.Split(letter).Length > 2)
                        {
                            blad = true;
                            break;
                        }
                    }
                }
            }
            while (blad == true);
            if (String.IsNullOrEmpty(klucz))
                klucz = "GADERYPOLUKI";
            klucz = klucz.Replace("-", "").ToUpper();
            Console.WriteLine("Podaj zdanie, które chcesz zaszyfrować");
            string do_utajnienia = Console.ReadLine();
            do_utajnienia = do_utajnienia.ToUpper();
            string zaszyfrowane = String.Empty;
            int index;
            char znak;
            for (int i = 0; i < do_utajnienia.Length; i++)
            {
                znak = do_utajnienia[i];
                if ((index = klucz.IndexOf(znak)) >= 0)
                {
                    if (index % 2 == 0)
                        zaszyfrowane += klucz[index + 1];
                    else
                        zaszyfrowane += klucz[index - 1];
                }
                else
                    zaszyfrowane += znak;

            }
            Console.WriteLine(zaszyfrowane);
            Console.ReadKey();
        }
    }
}
