using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib
{
    public class Service : IQuery
    {
        public uint Id { get; set; }
        public int IdCar { get; set; }
        public int Oil { get; set; }
        public bool ControlBreak { get; set; }
        public int Antifreeze { get; set; }
        public bool Tires { get; set; }

        public void Insert(ConnectionDB connection)
        {
            connection.Open();
            var sql = $"INSERT INTO service(id_auto, oil, control_break, antifreeze, tires)" +
                      $"VALUES ('{IdCar}','{Oil}','{ControlBreak}','{Antifreeze}','{Tires}');";
            connection.command.CommandText = sql;
            connection.command.ExecuteNonQuery();
            connection.Close();
        }

        public IList Select(ConnectionDB connection)
        {
            connection.Open();
            List<Service> list = new List<Service>();
            var sql = $@"SELECT * FROM service";
            connection.command.CommandText = sql;
            var reader = connection.command.ExecuteReader();
            if (!reader.HasRows) return null;
            while (reader.Read())
            {
                var id = reader.GetUInt32("id");
                var idAuto = reader.GetInt32("id_auto");
                var oil = reader.GetInt32("oil");
                var controlBreak = reader.GetBoolean("control_break");
                var antifreeze = reader.GetInt32("antifreeze");
                var tires = reader.GetBoolean("tires");
                list.Add(new Service
                {
                    Id = id,
                    IdCar = idAuto,
                    Oil = oil,
                    ControlBreak = controlBreak,
                    Antifreeze = antifreeze,
                    Tires = tires
                });
            }
            connection.Close();
            return list;
        }
    }
}