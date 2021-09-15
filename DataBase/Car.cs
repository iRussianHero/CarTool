using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib
{
    public class Car : IQuery
    {
        public int Id { get; set; }
        public string RegSign { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Mileage { get; set; }
        public string Colour { get; set; }

        public void Insert(ConnectionDB connection)
        {
        }

        public IList Select(ConnectionDB connection)
        {
            return new List<Car>();
        }
    }
}