using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using MySql.Data.MySqlClient;

namespace DataBaseLib
{
    public class DataBase
    {
        private const string driverType = "System.Collections.Generic.List`1[DataBaseLib.Driver]";
        private const string carType = "System.Collections.Generic.List`1[DataBaseLib.Car]";
        private const string serviceType = "System.Collections.Generic.List`1[DataBaseLib.Service]";

        public ConnectionDB connection;
        // connection - это подключение к базе данных
        // connection хранит в себе :
        // 1 connection.db; Хранит наш mysql60.hostland.ru|host1323541_sbd11|host1323541_itstep|269f43dc(Используется для открытия и закрытия доступа к  нашим таблицам)
        // 2 connection.command; Может считывать данные с таблиц mysql60.hostland.ru|host1323541_sbd11|host1323541_itstep|269f43dc
        // 3 connection.Open(); Открывает доступ к нашим таблицам (db.Open())
        // 4 connection.Close(); Закрывает доступ к нашим таблицам (db.Close())

        public DataBase()
        {
            connection = new ConnectionDB();
            string str = $"mysql60.hostland.ru|host1323541_sbd11|host1323541_itstep|269f43dc";
            var connectionString = ConnectionString.Init(str);
            connection.db = new MySqlConnection(connectionString);
            connection.command = new MySqlCommand() { Connection = connection.db };
        }

        // Примеры объявления методов и вызова их из классов

        public List<Driver> Select(string type)
        {
            Driver driver = new Driver();
            Car car = new Car();
            Service service = new Service();
            switch (type)
            {
                case driverType:
                    return (List<Driver>)driver.Select(connection);
                case carType:
                    return (List<Driver>)car.Select(connection);
                case serviceType:
                    return (List<Driver>)service.Select(connection);
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }
            return new List<Driver>();
        }

        public void Insert(Driver driver)
        {
            driver.Insert(connection);
        }
        public void Insert(Car car)
        {
            car.Insert(connection);
        }
        public void Insert(Service service)
        {
            service.Insert(connection);
        }
    }
}