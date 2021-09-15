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
    }
}