using System;
using System.Collections.Generic;

namespace DataBaseLib
{
    public class Insert
    {
        public static void Driver(Driver driver, ConnectionDB connection)
        {
            connection.Open();
            var sql = $"INSERT INTO driver(full_name,age,driving_experience,id_auto)" +
                      $"VALUES ('{driver.FullName}','{driver.Age}','{driver.DriveExp}','{driver.IdCar}');";
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }
    }
}