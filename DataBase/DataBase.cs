using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DataBaseLib
{
    public class DataBase
    {
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
        public List<Driver> SelectDriver() => Select.Driver(connection);
        public void InsertDriver(Driver driver) => Insert.Driver(driver, connection);

        // public void ExportProductsToCSV(string path) => Export.ProductsToCSV(path);
        // public void ExportOrdersToCSV(string path) => Export.OrdersToCSV(path);
        // public void ExportPeopleToCSV(string path) => Export.PeopleToCSV(path);
        // public void ImportOrderFromCSV(List<Orders> orders) => Import.OrderFromCSV(orders);
        // public void ImportProductsFromCSV(string path) => Import.ProductsFromCSV(path);
        // public void ImportPeopleFromCSV(string path) => Import.PeopleFromCSV(path);
    }
}