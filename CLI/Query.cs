using System;
using System.Collections.Generic;
using DataBaseLib;

namespace CLI
{
    public class Query // Запросы которые вызывают методы из DataBase
    {
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

            IQuery idriver = new Driver
            {
                FullName = fullName,
                Age = age,
                DriveExp = drivingExp,
                IdCar = idCar
            };
            db.Insert(idriver);
        }

        public static void PrintService()
        {
            DataBase db = new DataBase();
            IQuery iService = new Service();
            var list = (List<Service>)db.Select(iService);
            foreach (var service in list)
            {
                Show.PrintRed($"id автомобиля {service.IdCar}");
                Show.PrintGreen($"Последняя замена масла: {service.Oil}\nПоследняя замена масла: {service.Antifreeze}");
                Show.PrintYelloy($"Контроль тормозов: {service.ControlBreak}\nКонтроль шин: {service.Tires}\n");
            }
        }

        public static void InsertService()
        {
            var db = new DataBase();

            Show.PrintGreen("Введите id автомобиля:");
            var id_auto = Convert.ToInt32(Console.ReadLine());

            Show.PrintGreen("Введите пробег замены масла:");
            var oil = Convert.ToInt32(Console.ReadLine());

            Show.PrintGreen("Контроль тормозов (true|false):");
            var control_break = Convert.ToBoolean(Console.ReadLine());
            
            Show.PrintGreen("Ввведите пробег замены антифриза:");
            var antifreeze = Convert.ToInt32(Console.ReadLine());
            
            Show.PrintGreen("Контроль шин (true|false):");
            var tires = Convert.ToBoolean(Console.ReadLine());

            IQuery iService = new Service
            {
                IdCar = id_auto,
                Oil = oil,
                ControlBreak = control_break,
                Antifreeze = antifreeze,
                Tires = tires
            };
            db.Insert(iService);
        }
    }
}