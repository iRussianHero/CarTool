using System;
using System.Collections.Generic;
using DataBaseLib;

namespace CLI
{
    public class Menu // Этот клас создан для работы с меню
        //Класс Menu вызывает методы из класса Query
    {
        public static bool IsEmpty(string key)
        {
            if (key == string.Empty)
            {
                Console.WriteLine("Введен некорректный символ");
                return true;
            }

            return false;
        }

        static void DriverMenu()
        {
            Show.DriverMenu();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    Query.PrintDriver();
                    break;
                case "2":
                    Query.InsertDriver();
                    Show.PrintGreen($"Запрос отправлен");
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadLine();
        }

        static void CarMenu()
        {
            Show.CarMenu();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadLine();
        }

        static void ServiceMenu()
        {
            Show.ServiceMenu();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadLine();
        }

        static void Info()
        {
            Show.Info();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadLine();
        }

        public static void _Menu(string key)
        {
            if (IsEmpty(key)) return;
            switch (key)
            {
                case "1":
                    DriverMenu(); // Driver
                    break;
                case "2":
                    CarMenu(); // Car
                    break;
                case "3":
                    ServiceMenu(); // Service
                    break;
                case "4":
                    Info(); // Info car,driver
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }
        }
    }
}