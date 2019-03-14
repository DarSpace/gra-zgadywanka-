using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraZgadywanka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Gra za dużo za mało");
            

            #region losowanie 
            //1. Komputer losuje 

            var generator = new Random();
            int wylosowana = generator.Next(0, 101);
#if DEBUG == true
            Console.WriteLine(" " + wylosowana);              //do usuniecia  w wersji finalnej  
#endif
            Console.WriteLine(" Wylowowałem liczbe, odgadnij ją");
            #endregion

            int licznikRuchow = 0; 

            bool trafiono = false;
            do
            {



                #region propozycja gracza
                //2. gracz podaje poopozycje 
                Console.Write(" Podaj Twoją propozycję: ");
                string tekst = Console.ReadLine();
                //  Console.WriteLine($"podałeś tekst {tekst}");

                int propozycja = Convert.ToInt32(tekst);
                #endregion


                #region ocena komputera
                //3. komputer ocenia 

                if (wylosowana < propozycja)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Za dużo ");
                    Console.ResetColor();
                }
                else if (wylosowana > propozycja)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Za mało");
                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" TRAFIONO");
                    trafiono = true;
                    Console.ResetColor();
                }
                #endregion

                licznikRuchow++;
            }

            while (!trafiono);

            Console.WriteLine($" Liczba ruchów = {licznikRuchow}");
            Console.WriteLine(" Koniec gry");
            Console.ReadKey();

        }
    }
}
