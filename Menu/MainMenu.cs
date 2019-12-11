using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu
{
    public class MainMenu
    {
        public static void Run()
        {
            int i;
            bool flag=true;
            do
            {
                Console.WriteLine("Welcome to organizer!");
                Console.Write(
                    "1) Run Calculator\n" +
                    "2) Work with files 2\n" +
                    "3) Weather\n" +
                    "4) My func\n" +
                    "5) Exit\n");

                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Opening the calculator\n");
                        Process.Start("calc.exe");
                        TapAny();
                        break;
                    case 2:
                        Console.WriteLine("Files");
                        TapAny();
                        break;
                    case 3:
                        Console.WriteLine("Weather");
                        TapAny();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("My func");
                        TapAny();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(2000);
                        CloseProgram();
                        break;
                    default:
                        Console.WriteLine("Incorrect number. Please try again!");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            while (flag);
            Console.ReadKey();
        }
        public static void CloseProgram()
        {
            Process.GetCurrentProcess().Kill();
        }
        public static void TapAny()
        {
            Console.WriteLine("Tap any button to return");
        }
    }
}
