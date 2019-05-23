using System;
using System.Diagnostics;

namespace GraProceduralnie
{
    class Program
    {

       Stopwatch stoper = new Stopwatch();

        static int wylosowana = 0;
        /// <summary>
        /// Losuje liczbe całkowita z podanego zakresu, właczie ( trzy ukosniki to jest dokumentacja)
        /// </summary>
        /// <param name="min">Wartosc od ktorej losujemy włacznie </param>
        /// <param name="max">Wartosc do której losujemy wlczanie </param>
        /// <exception cref="ArgumentOutOfRangeException">jesli min > max </exception>
        static int Losuj(int min = 0, int max = 100)
        {

            if (min > max)
                throw new ArgumentOutOfRangeException("min jest wieksze niz max");
            var generator = new Random();
            return wylosowana = generator.Next(min, max + 1);
#if DEBUG == true
            Console.WriteLine(" " + wylosowana);              //do usuniecia  w wersji finalnej  
#endif
            Console.WriteLine(" Wylowowałem liczbe, odgadnij ją");
        }

        static int WczytajLiczbe(string prompt = " Podaj Twoją propozycję: ")
        {
            Console.Write(prompt);
            string tekst = Console.ReadLine();
             return Convert.ToInt32(tekst);
        }

        static string Ocena(int prop)
        {
            if (wylosowana < prop)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return " Za dużo ";
                //Console.WriteLine(" Za dużo ");
                Console.ResetColor();
            }
            else if (wylosowana > prop)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return " Za mało ";
               // Console.WriteLine(" Za mało");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                
                return " TRAFIONO "; // break;
                //Console.WriteLine(" TRAFIONO");
                
                Console.ResetColor();
            }
            return ""; // do zmiany
        }


        static void Main(string[] args)
        {
            //stoper.Start();

            Console.WriteLine(" Gra za dużo za mało");


            #region losowanie 
            //1. Komputer losuje 
            Console.WriteLine("Musze wylowosac liczbe z podanego przez Cb zakresu");
            Console.WriteLine("Podaj dolny i gorny zakres . Pamietaj ze dolny < gorny");
            int min = WczytajLiczbe("Podaj dolny zakres");
            int max = WczytajLiczbe("Podaj gorny zakres");
            Losuj(min, max);
            #endregion

            int licznikRuchow = 0;

           // bool trafiono = false;
            do
            {



                #region propozycja gracza
                //2. gracz podaje poopozycje 
               

                int propozycja;
                try
                {
                    propozycja = WczytajLiczbe(" Podaj Twoją propozycję: ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie dodałes liczby, sprój jeszcze raz");
                    licznikRuchow++;
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Podana liczba wykracza poza zakres od {int.MinValue} do {int.MaxValue}, sprój jeszcze raz");
                    licznikRuchow++;
                    continue;
                }
                #endregion


                #region ocena komputera
                
                string wynik = Ocena(propozycja);
                Console.WriteLine( wynik);
                if (wynik == " TRAFIONO ")
                    break;


                //if (wylosowana < propozycja)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine(" Za dużo ");
                //    Console.ResetColor();
                //}
                //else if (wylosowana > propozycja)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine(" Za mało");
                //    Console.ResetColor();

                //}
                //else
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine(" TRAFIONO");
                //    trafiono = true;
                //    Console.ResetColor();
                //}
                #endregion

                licznikRuchow++;
            }

            while (true);     //!trafiono zamiast true jak jest bool trafiono 
            //stoper.Stop();
           // Console.WriteLine($" Liczba ruchów = {licznikRuchow}, czas gry = {stoper.Elasped}");
            Console.WriteLine(" Koniec gry");
            Console.ReadKey();

        }
    }
}
