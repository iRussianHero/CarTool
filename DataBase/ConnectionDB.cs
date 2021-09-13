using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace DataBaseLib
{
    public class ConnectionDB
    {
        public MySqlConnection db;
        public MySqlCommand command;

        public void Open()
        {
            db.Open();
        }

        public void Close()
        {
            db.Close();
        }

        public ConnectionDB()
        {
            db = new MySqlConnection();
            command = new MySqlCommand();
        }
        public ConnectionDB(string connection)
        {
            db = new MySqlConnection(connection);
            command = new MySqlCommand() { Connection = db };
        }
    }
}