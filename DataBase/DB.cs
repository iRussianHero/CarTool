using System.Collections.Generic;
using System.Dynamic;
using DataBase;
using MySql.Data.MySqlClient;

namespace SalesLib
{
    public class DataBase : ConnectionDB
    {
        public DataBase()
        {

            var connectionString = $"Server={mysql60.hostland.ru};Database={host1323541_sbd16};Uid={host1323541_itstep};Pwd={269f43dc}";
               // нужно разделить
            //ConnectionString.Init(@"db_connect.ini");
            db = new MySqlConnection(
                connectionString);
            command = new MySqlCommand() { Connection = db };
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