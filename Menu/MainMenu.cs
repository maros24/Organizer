﻿using BusinessLogic;
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
                Console.Clear();
                Console.WriteLine("\n{0,50}","WELCOME TO ORGANIZER, "+ Environment.UserName+"!\n");
                Console.WriteLine(" Please select an item from Menu\n");
                Console.Write( 
                    " 1) Run Calculator\n" +
                    " 2) Work with files\n" +
                    " 3) View current weather\n" +
                    " 4) My function\n" +
                    " 5) Exit\n");

                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Opening the calculator\n");
                        Process.Start("calc.exe");
                        Helper.TapAny();
                        break;
                    case 2:
                        FileMenu.OpenFileMenu();
                        Helper.TapAny();
                        break;
                    case 3:
                        WeatherData.GetWeather();
                        Helper.TapAny();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("My func");
                        Helper.TapAny();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(2000);
                        Helper.CloseProgram();
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
    }
}
