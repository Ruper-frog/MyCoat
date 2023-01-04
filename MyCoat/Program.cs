using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
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
            Console.WriteLine("____________________________________");
            Console.WriteLine("C- Clear Screen, P- Change Pen, L- Change Color, U- Pen Up, D- Pen Down, Escape - Exit");
            Console.SetCursorPosition(1, 1);

            keyinfo = Console.ReadKey();
            int Cheat = NewMethod1();
            while (keyinfo.Key != ConsoleKey.Escape)
            {
                keyinfo = Console.ReadKey();

                // Move corsore
                if (keyinfo.Key == ConsoleKey.RightArrow) x++;
                if (keyinfo.Key == ConsoleKey.LeftArrow) x--;
                if (keyinfo.Key == ConsoleKey.DownArrow) y++;
                if (keyinfo.Key == ConsoleKey.UpArrow) y--;

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
                    Console.WriteLine("____________________________________");
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

                if (keyinfo.Key == ConsoleKey.P)
                {
                    Cheat = 1;
                }
                if (keyinfo.Key == ConsoleKey.I && Cheat == 1)
                {
                    Cheat = 2;
                }
                if (keyinfo.Key == ConsoleKey.Z && Cheat == 2)
                {
                    Cheat = 3;
                }
                if (keyinfo.Key == ConsoleKey.Z && Cheat == 3)
                {
                    Cheat = 4;
                }
                if (keyinfo.Key == ConsoleKey.A && Cheat == 4)
                {
                    Console.SetCursorPosition(45, 10);
                    Console.WriteLine("you broke the system");
                }
                if (keyinfo.Key != ConsoleKey.P && keyinfo.Key != ConsoleKey.I && keyinfo.Key != ConsoleKey.Z && keyinfo.Key != ConsoleKey.A)
                {
                    Cheat = 0;
                }
            }
        }
        private static int NewMethod1()
        {
            return NewMethod();
        }
        private static int NewMethod()
        {
            return 0;
        }
    }
}
