using System;
using System.Collections.Generic;
using DataBaseLib;

namespace CLI
{
    public class Menu
    {
        const string driverType = "System.Collections.Generic.List`1[DataBaseLib.Driver]";
        const string CarType = "System.Collections.Generic.List`1[DataBaseLib.Car]";
        const string ServiceType = "System.Collections.Generic.List`1[DataBaseLib.Service]";

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
            Show.SubMenu1();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    PrintDriver();
                    break;
                case "2":
                    InsertDriver();
                    Show.PrintGreen($"Запрос отправлен");
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "0":
                    Show.Menu();
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
            Show.SubMenu2();
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
                    Show.Menu();
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
            Show.SubMenu3();
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
                    Show.Menu();
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
            Show.SubMenu4();
            var key = Convert.ToString(Console.ReadLine());
            if (IsEmpty(key)) return;

            switch (key)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    Show.Menu();
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadLine();
        }

        public static void PrintDriver()
        {
            DataBase db = new DataBase();
            IQuery idriver = new Driver();
            var list = (List<Driver>)db.Select(idriver);
            foreach (var driver in list)
            {
                Show.PrintRed($"id водителя {driver.Id}");
                Show.PrintGreen($"{driver.FullName} {driver.Age} лет");
                Show.PrintYelloy($"Cтаж вождения - {driver.DriveExp}, id автомобиля - {driver.IdCar}\n");
            }
        }

        public static void InsertDriver()
        {
            var db = new DataBase();

            Show.PrintGreen("Введите Имя и фамилию в одну строчку");
            var fullName = Convert.ToString(Console.ReadLine());

            Show.PrintGreen("Введите возраст");
            var age = Convert.ToUInt32(Console.ReadLine());

            Show.PrintGreen("Введите стаж вождения");
            var drivingExp = Convert.ToUInt32(Console.ReadLine());

            //db.SelectCar();  //  Ждать пока Алексей напишет метод
            Show.PrintGreen("Введите id автомобиля");
            var idCar = Convert.ToUInt32(Console.ReadLine());

            // var driver = new Driver
            // {
            //     FullName = fullName,
            //     Age = age,
            //     DriveExp = drivingExp,
            //     IdCar = idCar
            // };
            // IQuery idriver = driver; 
            // db.Insert(idriver);

            IQuery idriver = new Driver
            {
                FullName = fullName,
                Age = age,
                DriveExp = drivingExp,
                IdCar = idCar
            };
            db.Insert(idriver);
        }

        public static void SubMenu(string key)
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