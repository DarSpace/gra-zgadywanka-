﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogikaGry;

namespace ConsoleAppTestGra
{
    class Program
    {

        static void Main(string[] args)
        {
            Gra g = new Gra(1, 10);
            Gra.Odp odp = g.Ocena(5);
            Console.WriteLine( odp);
            if (odp != Gra.Odp.Trafiono)
                odp = g.Ocena(7);
            if (odp != Gra.Odp.Trafiono)
                odp = g.Ocena(3);
            foreach( var ruch in g.Historia )
            {
                Console.WriteLine( $"{ruch.propozycja} {ruch.odp} {ruch.kiedy}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine( Ruch.Licznik);
            Ruch r = new Ruch(10, Gra.Odp.ZaDuzo);
            Console.WriteLine(Ruch.Licznik);
            
            Console.WriteLine(r.Licznik);
        }
    }
}
