using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyinfo;
            char s = '*';
            bool penDown = true;
            int x = 0, y = 0;

            // MENU //
            Console.SetCursorPosition(1, 20);
            Console.WriteLine("____________");
            Console.WriteLine("C- Clear Screen, P- Change Pen, L- Change Color, U- Pen Up, D- Pen Down, Escape - Exit");
            Console.SetCursorPosition(1, 1);


            keyinfo = Console.ReadKey();
            Console.SetWindowSize(150, 50);

            while (keyinfo.Key != ConsoleKey.Escape)
            {
                keyinfo = Console.ReadKey();

                // Move corsore
                if (keyinfo.Key == ConsoleKey.RightArrow && x < 100)
                    x++;

                if (keyinfo.Key == ConsoleKey.LeftArrow && x > 0)
                    x--;

                if (keyinfo.Key == ConsoleKey.DownArrow && y < 19)
                {
                    y++;
                }
                if (keyinfo.Key == ConsoleKey.UpArrow && y > 0)
                {
                    y--;
                }

                Console.CursorSize = 20;

                // Other menu keys

                if (keyinfo.Key == ConsoleKey.U) penDown = false;
                if (keyinfo.Key == ConsoleKey.D) penDown = true;
                if (keyinfo.Key == ConsoleKey.R) Console.BackgroundColor = ConsoleColor.Red;
                if (keyinfo.Key == ConsoleKey.W) Console.BackgroundColor = ConsoleColor.White;

                if (keyinfo.Key == ConsoleKey.C)
                {
                    Console.Clear();
                    // MENU //
                    Console.SetCursorPosition(1, 20);
                    Console.WriteLine("____________");
                    Console.WriteLine("C- Clear Screen, P- Change Pen, L- Change Color, U- Pen Up, D- Pen Down, Escape - Exit");
                    Console.SetCursorPosition(1, 1);
                }

                if (keyinfo.Key == ConsoleKey.P)
                {
                    if (s == '*')
                        s = '+';
                    else
                        s = '*';
                }

                // Set Cursoe Position and pain if pen is down.

                Console.SetCursorPosition(x, y);
                if (penDown) Console.Write(s);

            }
        }
    }
}