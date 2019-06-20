using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraSnake
{   //po przejsciu gry zgadywanki po tym jak wygra sie gre  włancza sie gra snake,
    class Program
    {
        static void Main(string[] args)
        {
            int starNumber = 50;
            Random los = new Random();
            for (int i = 0; i < starNumber; i++)
            {
                Console.SetCursorPosition(los.Next(Console.WindowWidth), los.Next(Console.WindowHeight));
                Console.Write('*');
            }

            int len = 25;
            int[] snake_x = new int[len];
            int[] snake_y = new int[len];

            char mark = '*';

            for (int i = 0; i < snake_x.Length; i++)
            {
                snake_x[i] = i + 1;
                snake_y[i] = 10;
                Console.SetCursorPosition(snake_x[i], snake_y[i]);
                Console.Write(mark);
            }

            int head_x = snake_x[snake_x.Length - 1];
            int head_y = snake_y[snake_y.Length - 1];

            ConsoleKey znak = ConsoleKey.RightArrow;

            char charHead = '☻';

            bool isNotEnd = true;
            while (isNotEnd)
            {
                if (Console.KeyAvailable)
                    znak = Console.ReadKey(true).Key;


                switch (znak)
                {
                    case ConsoleKey.LeftArrow: if (head_x > 1) head_x--; break;
                    case ConsoleKey.RightArrow: if (head_x < 89) head_x++; break;
                    case ConsoleKey.UpArrow: if (head_y > 1) head_y--; break;
                    case ConsoleKey.DownArrow: if (head_y < 27) head_y++; break;
                    default: isNotEnd = false; break;
                }


                Console.SetCursorPosition(snake_x[0], snake_y[0]);
                Console.Write(' ');

                for (int i = 0; i < snake_x.Length - 1; i++)
                {
                    snake_x[i] = snake_x[i + 1];
                    snake_y[i] = snake_y[i + 1];
                }

                snake_x[snake_x.Length - 1] = head_x;
                snake_y[snake_y.Length - 1] = head_y;

                for (int i = 0; i < snake_x.Length - 1; i++)
                {
                    Console.SetCursorPosition(snake_x[i], snake_y[i]);
                    Console.Write(mark);
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(head_x, head_y);
                Console.Write(charHead);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                System.Threading.Thread.Sleep(500);
            }
            Console.Clear();
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("KONIEC");


        }
    }
}
