using System;
using System.Collections.Generic;

namespace DataBaseLib
{
    public class Insert
    {
        public static void Driver(List<Driver> list1, ConnectionDB connection)
        {
            connection.Open();
            var sql = string.Empty;
            foreach (var list in list1)
            {
                sql += $"INSERT INTO driver(full_name,age,driving_experience,id_auto)" +
                       $"VALUES ('{list.FullName}','{list.Age}','{list.DriveExp}','{list.IdCar}');";
            }
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }
    }
}