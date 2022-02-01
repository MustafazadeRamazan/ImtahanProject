using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspectors
{
    class Inspector 
    {
        public static int SelectionControl(string[] menu)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write($"\n\n\n\t\t{menu[0]}");
            Console.ResetColor();

            for (int i = 1; i < menu.Length; i++)
            {
                Console.Write($"\t\t{menu[i]}");
            }

            int index = 0;

            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                {
#pragma warning disable CA1416
                    Console.Beep(1000, 100);
#pragma warning restore CA1416

                    Loading.loading();
                    return -1;
                }

                else if (key.Key == ConsoleKey.Enter)
                {
#pragma warning disable CA1416
                    Console.Beep(1000, 100);
#pragma warning restore CA1416

                    Loading.loading();
                    break;
                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
#pragma warning disable CA1416
                    Console.Beep(1236,90);
#pragma warning restore CA1416

                    if (index + 1 == menu.Length)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t " + @" ____                                        ");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ \                                       ");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) |   ___    ___   ___        __ _   ____");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ <   / _ \  / __| / __|      / _` | |_  /");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) | | (_) | \__ \ \__ \  _  | (_| |  / / ");
                        Console.WriteLine("\t\t\t\t\t " + @"|____/   \___/  |___/ |___/ (_)  \__,_| /___|");
                        Console.ResetColor();

                        index = 0;
                        Console.WriteLine("\n\n");

                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == index)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write($"\t\t{menu[i]}");
                                Console.ResetColor();
                                continue;
                            }
                            Console.Write($"\t\t{menu[i]}");
                        }

                        Thread.Sleep(50);
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t " + @" ____                                        ");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ \                                       ");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) |   ___    ___   ___        __ _   ____");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ <   / _ \  / __| / __|      / _` | |_  /");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) | | (_) | \__ \ \__ \  _  | (_| |  / / ");
                        Console.WriteLine("\t\t\t\t\t " + @"|____/   \___/  |___/ |___/ (_)  \__,_| /___|");
                        Console.ResetColor();
                        Console.WriteLine("\n\n");
                        index++;
                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == index)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write($"\t\t{menu[i]}");
                                Console.ResetColor();
                                continue;
                            }
                            Console.Write($"\t\t{menu[i]}");
                        }
                        Thread.Sleep(50);
                    }
                }

                else if (key.Key == ConsoleKey.UpArrow)
                {
#pragma warning disable CA1416 // Validate platform compatibility
                    Console.Beep(1236, 90);
#pragma warning restore CA1416 // Validate platform compatibility
                    if (index - 1 < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t " + @" ____                                        ");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ \                                       ");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) |   ___    ___   ___        __ _   ____");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ <   / _ \  / __| / __|      / _` | |_  /");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) | | (_) | \__ \ \__ \  _  | (_| |  / / ");
                        Console.WriteLine("\t\t\t\t\t " + @"|____/   \___/  |___/ |___/ (_)  \__,_| /___|");
                        Console.ResetColor();

                        index = menu.Length - 1;
                        Console.WriteLine("\n\n");

                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == index)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write($"\t\t{menu[i]}");
                                Console.ResetColor();
                                continue;
                            }
                            Console.Write($"\t\t{menu[i]}");
                        }

                        Thread.Sleep(50);
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\t\t\t\t\t " + @" ____                                        ");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ \                                       ");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) |   ___    ___   ___        __ _   ____");
                        Console.WriteLine("\t\t\t\t\t " + @"|  _ <   / _ \  / __| / __|      / _` | |_  /");
                        Console.WriteLine("\t\t\t\t\t " + @"| |_) | | (_) | \__ \ \__ \  _  | (_| |  / / ");
                        Console.WriteLine("\t\t\t\t\t " + @"|____/   \___/  |___/ |___/ (_)  \__,_| /___|");
                        Console.ResetColor();

                        index--;
                        Console.WriteLine("\n\n");

                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == index)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write($"\t\t{menu[i]}");
                                Console.ResetColor();
                                continue;
                            }
                            Console.Write($"\t\t{menu[i]}");
                        }

                        Thread.Sleep(50);
                    }
                }

                else
                    continue;
            }
            return index;
        }
        public static string PasswordGenerator(string? text, string? username)
        {
            string inbox = string.Empty;
            ushort count = 1;
            Console.Write(text);
            while (true)
            {
                var key = Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\t\t\t" + @" _                        _               _____                         ");
                Console.WriteLine("\t\t\t" + @"| |                      (_)             |  __ \                        ");
                Console.WriteLine("\t\t\t" + @"| |        ___     __ _   _   _ __       | |__) |   __ _    __ _    ___ ");
                Console.WriteLine("\t\t\t" + @"| |       / _ \   / _` | | | | '_ \      |  ___/   / _` |  / _` |  / _ \");
                Console.WriteLine("\t\t\t" + @"| |____  | (_) | | (_| | | | | | | |     | |      | (_| | | (_| | |  __/");
                Console.WriteLine("\t\t\t" + @"|______|  \___/   \__, | |_| |_| |_|     |_|       \__,_|  \__, |  \___|");
                Console.WriteLine("\t\t\t" + @"                   __/ |                                    __/ |       ");
                Console.WriteLine("\t\t\t" + @"                  |___/                                    |___/        ");

                Console.WriteLine($"\n\n\n\t\t\u25ba Enter Password: {username}");
                Console.Write(text);

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return inbox;
                }

                char CharKey = key.KeyChar;
                inbox += CharKey;

                for (int i = 0; i < count; i++)
                {
                    Console.Write("*");
                }
                count++;
            }

        }

        public static void NewWorkText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t" + @" _   _                  __          __           _    ");
            Console.WriteLine("\t\t\t\t" + @"| \ | |                 \ \        / /          | |   ");
            Console.WriteLine("\t\t\t\t" + @"|  \| |  ___ __      __  \ \  /\  / /___   _ __ | | __");
            Console.WriteLine("\t\t\t\t" + @"| . ` | / _ \\ \ /\ / /   \ \/  \/ // _ \ | '__|| |/ /");
            Console.WriteLine("\t\t\t\t" + @"| |\  ||  __/ \ V  V /     \  /\  /| (_) || |   |   < ");
            Console.WriteLine("\t\t\t\t" + @"|_| \_| \___|  \_/\_/       \/  \/  \___/ |_|   |_|\_\");
        }

        public static void BossAzText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t " + @" ____                                        ");
            Console.WriteLine("\t\t\t\t\t " + @"|  _ \                                       ");
            Console.WriteLine("\t\t\t\t\t " + @"| |_) |   ___    ___   ___        __ _   ____");
            Console.WriteLine("\t\t\t\t\t " + @"|  _ <   / _ \  / __| / __|      / _` | |_  /");
            Console.WriteLine("\t\t\t\t\t " + @"| |_) | | (_) | \__ \ \__ \  _  | (_| |  / / ");
            Console.WriteLine("\t\t\t\t\t " + @"|____/   \___/  |___/ |___/ (_)  \__,_| /___|");
        }
    }
}
