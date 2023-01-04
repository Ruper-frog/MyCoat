﻿using System;

namespace MyCoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gameStart();
            game();
        }
        //Decoration Department, Cheat Team, 
        static void game()
        {
            //Decoration Departmetn
            ConsoleKeyInfo keyinfo;
            string s = "♥️";
            bool penDown = true, Menu = true;
            int x = 1, y = 1;
            //Cheat Team
            int Cheat = NewMethod1();
            //Decoration Department
            do
            {
                if (Menu)
                {
                    // MENU //
                    Console.Clear();

                    trial();
                    corners();

                    Console.SetCursorPosition(2, 27);
                    Console.WriteLine("C- Clear Screen, W- Change Pen, R (red) and W (white)- Change Color.");
                    Console.SetCursorPosition(2, 28);
                    Console.WriteLine("U- Pen Up, D- Pen Down, Escape - Exit");
                    Console.SetCursorPosition(1, 1);

                    Console.SetCursorPosition(x, y);
                }

                Menu = false;

                keyinfo = Console.ReadKey();
                Console.SetCursorPosition(x, y);

                if (keyinfo.Key == ConsoleKey.C)
                    Menu = true;

                // Move corsore
                if (keyinfo.Key == ConsoleKey.RightArrow) x++;
                if (keyinfo.Key == ConsoleKey.LeftArrow) x--;
                if (keyinfo.Key == ConsoleKey.DownArrow) y++;
                if (keyinfo.Key == ConsoleKey.UpArrow) y--;

                //frame               

                // Other menu keys

                if (keyinfo.Key == ConsoleKey.U) penDown = false;
                if (keyinfo.Key == ConsoleKey.D) penDown = true;
                if (keyinfo.Key == ConsoleKey.R) Console.ForegroundColor = ConsoleColor.Red;
                if (keyinfo.Key == ConsoleKey.W) Console.ForegroundColor = ConsoleColor.White;

                //Decoration Department
                if (keyinfo.Key == ConsoleKey.W)
                {
                    if (s == "♥️")
                        s = "▓";
                    else if (s == "▓")
                        s = "■";
                    else
                        s = "♥️";
                }

                //Cheat Team
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

                // Set Cursoe Position and pain if pen is down.

                Console.SetCursorPosition(x, y);
                if (penDown) Console.Write(s);

            } while (keyinfo.Key != ConsoleKey.Escape);
        }
        //Decoration Department
        static void trial()
        {
            //למעלה
            int x = 1, y = 0;
            for (int i = 0; i < 118; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('═');
                x++;
            }
            //שמאל
            x = 0; y = 1;
            for (int b = 0; b < 24; b++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('║');
                y++;
            }
            //ימין
            x = 119; y = 1;
            for (int b = 0; b < 24; b++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine('║');
                y++;
            }
            //למטה
            x = 1; y = 25;
            for (int c = 0; c < 118; c++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write('═');
                x++;
            }
        }
        //Decoration Department
        static void corners()
        {
            //שמאל למעלה
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            //שמאל למטה
            Console.SetCursorPosition(0, 25);
            Console.Write("╚");
            //ימין למטה
            Console.SetCursorPosition(119, 25);
            Console.Write("╝");
            //ימין למעלה
            Console.SetCursorPosition(119, 0);
            Console.Write("╗");
            Console.SetCursorPosition(2, 1);
        }
        //Decoration Department
        static void gameStart()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(1, 4);
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
            Console.SetCursorPosition(2, 20);
            Console.WriteLine("Press ENTER to continue ");

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

            } while (keyinfo.Key != ConsoleKey.Enter);

            Console.Clear();
        }
        //Cheat Team
        private static int NewMethod1()
        {
            return NewMethod();
        }
        //Cheat Team
        private static int NewMethod()
        {
            return 0;
        }
    }
}