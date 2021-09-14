using System;
using System.Collections;
using System.Collections.Generic;

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
                      $"VALUES ('{this.FullName}','{this.Age}','{this.DriveExp}','{this.IdCar}');";
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }

        public IList Select(ConnectionDB db)
        {
            db.Open();
            List<Driver> list = new List<Driver>();
            var sql = $@"SELECT * FROM driver";
            db.command.CommandText = sql;
            var reader = db.command.ExecuteReader();
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
            db.Close();
            return list;
        }
    }
}