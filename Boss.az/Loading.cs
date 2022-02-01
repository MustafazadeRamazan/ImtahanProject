using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public class Loading
{
    public static void loading()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.CursorVisible = false;
        Console.Write("\n\n\n\n\n\n\t\t\t\t\t L O A D I N G : ");

        for (int i = 1; i <= 12; i++)
        {
            Thread.Sleep(100);
            Console.Write($"{(char)1422}");
        }

        Console.Clear();
        Console.CursorVisible = true;
    }

    public static void WrongPassword()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.CursorVisible = false;

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(200);
            Console.Beep();
            Console.Write("\n\n\n\n\n\n\t\t\t\t\t W r o n g  P a s s w o r d");
            Thread.Sleep(200);
            Console.Beep();
            Console.Clear();
        }

        Console.CursorVisible = true;
    }

    public static void WrongEmail()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.CursorVisible = false;

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(200);
            Console.Beep();
            Console.Write("\n\n\n\n\n\n\t\t\t\t\t W r o n g  E m a i l");
            Thread.Sleep(200);
            Console.Beep();
            Console.Clear();
        }

        Console.CursorVisible = true;
    }
}

