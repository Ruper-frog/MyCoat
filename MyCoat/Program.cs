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
            gameStart();
            trial();
            corners();
            game();
        }

        static void game()
        {
            ConsoleKeyInfo keyinfo;
            char s = '♥️';
            bool penDown = true;
            int x = 0, y = 0;

            // MENU //
            Console.SetCursorPosition(2, 33);
            Console.WriteLine("C- Clear Screen, P- Change Pen, R (red) and W (white)- Change Color.");
            Console.SetCursorPosition(2, 34);
            Console.WriteLine("U- Pen Up, D- Pen Down, Escape - Exit");
            Console.SetCursorPosition(1, 1);

            keyinfo = Console.ReadKey();

            while (keyinfo.Key != ConsoleKey.Escape)
            {
                keyinfo = Console.ReadKey();
                Console.SetCursorPosition(1, 1);

                // Move corsore
                if (keyinfo.Key == ConsoleKey.RightArrow) x++;
                if (keyinfo.Key == ConsoleKey.LeftArrow) x--;
                if (keyinfo.Key == ConsoleKey.DownArrow) y++;
                if (keyinfo.Key == ConsoleKey.UpArrow) y--;

                //frame               

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
                    Console.WriteLine("C- Clear Screen, P- Change Pen, R (red) and W (white)- Change Color, U- Pen Up, D- Pen Down, Escape - Exit");
                    Console.SetCursorPosition(1, 1);
                }

                if (keyinfo.Key == ConsoleKey.P)
                {
                    if (s == '♥️')
                        s = '▓';
                    else if (s == '▓')
                        s = '■';
                    else
                        s = '♥️';
                }

                // Set Cursoe Position and pain if pen is down.

                Console.SetCursorPosition(x, y);
                if (penDown) Console.Write(s);

            }
        }
        static void trial()
        {

            //למעלה
            int x = 1, y = 0;
            for (int i = 0; i < 90; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('═');
                x++;
            }
            //שמאל
            x = 0; y = 1;
            for (int b = 0; b < 35; b++)
            {
                Console.WriteLine('║');
                y++;
            }
            //ימין
            x = 91; y = 1;
            for (int b = 0; b < 35; b++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('║');
                y++;
            }
            //למטה
            x = 1; y = 35;
            for (int c = 0; c < 90; c++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('═');
                x++;
            }
        }
        static void corners()
        {
            //שמאל למעלה
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            //שמאל למטה
            Console.SetCursorPosition(0, 35);
            Console.Write("╚");
            //ימין למטה
            Console.SetCursorPosition(91, 35);
            Console.Write("╝");
            //ימין למעלה
            Console.SetCursorPosition(91, 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, 30);

        }
        static void gameStart()
        {
            Console.WindowHeight = 36;
            Console.WindowWidth = 92;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(@"
 _____ _             _    ______     _       _                                
/  ___| |           | |   | ___ \   (_)     | |                               
\ `--.| |_ __ _ _ __| |_  | |_/ /_ _ _ _ __ | |_    __ _  __ _ _ __ ___   ___ 
 `--. \ __/ _` | '__| __| |  __/ _` | | '_ \| __|  / _` |/ _` | '_ ` _ \ / _ \
/\__/ / || (_| | |  | |_  | | | (_| | | | | | |_  | (_| | (_| | | | | | |  __/
\____/ \__\__,_|_|   \__| \_|  \__,_|_|_| |_|\__|  \__, |\__,_|_| |_| |_|\___|
                                                    __/ |                     
                                                   |___/                      
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                          
");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, 30);
            Console.WriteLine("Press ENTER to continue ");

            ConsoleKeyInfo keyinfo;
            keyinfo = Console.ReadKey();

            if (keyinfo.Key == ConsoleKey.Enter) Console.Clear();


        }


    }
}