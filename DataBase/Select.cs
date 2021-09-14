using System;
using System.Collections.Generic;

namespace DataBaseLib
{
    public class Select ////в этом классе пишем только SELECT запросы
    { 
        public static List<Driver> Driver(ConnectionDB db)
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