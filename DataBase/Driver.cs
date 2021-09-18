using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DataBaseLib
{
    public class Driver : IQuery
    {
        public uint Id { get; set; }
        public string FullName { get; set; }
        public uint Age { get; set; }
        public uint DriveExp { get; set; }
        public uint IdCar { get; set; }

        public void Insert(ConnectionDB connection)
        {
            connection.Open();
            var sql = $"INSERT INTO driver(full_name,age,driving_experience,id_auto)" +
                      $"VALUES ('{FullName}','{Age}','{DriveExp}','{IdCar}');";
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }

        public IList Select(ConnectionDB connection)
        {
            connection.Open();
            List<Driver> list = new List<Driver>();
            var sql = $@"SELECT * FROM driver";
            connection.command.CommandText = sql;
            var reader = connection.command.ExecuteReader();
            if (!reader.HasRows) return null;
            while (reader.Read())
            {
                var id = reader.GetUInt32("id");
                var fullName = reader.GetString("full_name");
                var age = reader.GetUInt32("age");
                var drivingExperience = reader.GetUInt32("driving_experience");
                var idCar = reader.GetUInt32("id_auto");
                list.Add(new Driver
                {
                    Id = id,
                    FullName = fullName,
                    Age = age,
                    DriveExp = drivingExperience,
                    IdCar = idCar
                });
            }

            connection.Close();
            return list;
        }

        public void Export(ConnectionDB connection, string path)
        {
            var drivers = Select(connection);
            var list = (List<Driver>)drivers;
            using var file = new StreamWriter(path, false);
            foreach (var driver in list)
            {
                file.WriteLine($"{driver.Id}|{driver.FullName}|{driver.Age}|{driver.DriveExp}|{driver.IdCar}");
            }
        }

        public void Import(ConnectionDB connection, string path)
        {
            connection.Open();
            var drivers = new List<Driver>();
            using (StreamReader file = new StreamReader(path))
            {
                var list = string.Empty;
                while ((list = file.ReadLine()) != null)
                {
                    var temp = list.Split("|");
                    var driver = new Driver()
                    {
                        Id = uint.Parse(temp[0]),
                        FullName = temp[1],
                        Age = uint.Parse(temp[2]),
                        DriveExp = uint.Parse(temp[3]),
                        IdCar = uint.Parse(temp[4])
                    };
                    drivers.Add(driver);
                }
            }

            string sql = string.Empty;
            foreach (var driver in drivers)
            {
                sql = $"INSERT INTO driver(full_name,age,driving_experience,id_auto)" +
                      $"VALUES ('{driver.FullName}','{driver.Age}','{driver.DriveExp}','{driver.IdCar}');";
                connection.command.CommandText = sql;
                connection.command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}