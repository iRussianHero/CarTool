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
        public int Id { get; set; }
        public int IdCar { get; set; }
        public int Oil { get; set; }
        public bool ControlBreak { get; set; }
        public int Antifreeze { get; set; }
        public bool Tires { get; set; }

        public void Insert(ConnectionDB connection)
        {
         
        }

        public IList Select(ConnectionDB connection)
        {
            return new List<Car>();
        }
    }
}