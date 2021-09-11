using MySql.Data.MySqlClient;

namespace DataBaseLib
{
    public class DataBase
    {
        public ConnectionDB data;

        public DataBase()
        {
            data = new ConnectionDB();
            string str = $"mysql60.hostland.ru|host1323541_sbd11|host1323541_itstep|269f43dc";
            var connectionString = ConnectionString.Init(str);
            data.db = new MySqlConnection(connectionString);
            data.command = new MySqlCommand() { Connection = data.db };
        }

        // Примеры объявления методов и вызова их из классов
        // public void ExportProductsToCSV(string path) => Export.ProductsToCSV(path);
        // public void ExportOrdersToCSV(string path) => Export.OrdersToCSV(path);
        // public void ExportPeopleToCSV(string path) => Export.PeopleToCSV(path);
        // public void ImportOrderFromCSV(List<Orders> orders) => Import.OrderFromCSV(orders);
        // public void ImportProductsFromCSV(string path) => Import.ProductsFromCSV(path);
        // public void ImportPeopleFromCSV(string path) => Import.PeopleFromCSV(path);
    }
}