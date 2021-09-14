using System;
using System.Collections.Generic;

namespace DataBaseLib
{
    public class Insert
    {
        public static void Driver(List<Driver> list, ConnectionDB connection)
        {
            connection.Open();
            var sql = string.Empty;
                sql = $"INSERT INTO driver(full_name,age,driving_experience,id_auto)" +
                       $"VALUES ('{list[0].FullName}','{list[0].Age}','{list[0].DriveExp}','{list[0].IdCar}');";
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }
    }
}