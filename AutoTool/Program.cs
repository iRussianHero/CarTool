using System;
using CLI;
using DataBaseLib;

namespace AutoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            do
            {
                Show.Menu();
                key = Convert.ToString(Console.ReadLine());
                SubMenu(key);
            } while (true);
        }

        public static bool IsEmpty(string key)
        {
            if (key == string.Empty)
            {
                Console.WriteLine("Введен некорректный символ");
                return true;
            }

            return false;
        }

        public static void PrintDriver(DataBase driver)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var list = driver.GetDriver();
            foreach (var var in list)
            {
                Console.WriteLine($"{var.FullName} {var.Age} лет" +
                                  $"\n Cтаж вождения - {var.DriveExp}, id автомобиля - {var.IdCar}\n");
            }

            Console.ResetColor();
        }

        public static void SubMenu(string key)
        {
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
                case "5":
                    return; // quit
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            static void DriverMenu()
            {
                Show.SubMenu1();
                var key = Convert.ToString(Console.ReadLine());
                if (IsEmpty(key))
                {
                    return;
                }
                switch (key)
                {
                    case "1":
                        DataBase db = new DataBase();
                        PrintDriver(db);
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

                Console.ReadLine();
            }

            static void CarMenu()
            {
                Show.SubMenu2();
                var key = Convert.ToString(Console.ReadLine());
                if (IsEmpty(key))
                {
                    return;
                }

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
                Console.ReadLine();
            }

            static void ServiceMenu()
            {
                Show.SubMenu3();
                var key = Convert.ToString(Console.ReadLine());
                if (IsEmpty(key))
                {
                    return;
                }

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
                Console.ReadLine();
            }

            static void Info()
            {
               Show.SubMenu4();
                var key = Convert.ToString(Console.ReadLine());
                if (IsEmpty(key))
                {
                    return;
                }

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
                Console.ReadLine();
            }
        }
    }
}