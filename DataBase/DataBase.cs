using System.Collections;
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

        public IList Select(IQuery _inteface)
        {
            return _inteface.Select(connection);
        }

        public void Insert(IQuery _interface)
        {
            _interface.Insert(connection);
        }

        public void Export(IQuery _inteface)
        {
            _inteface.Export(connection, _inteface + ".csv");
        }

        public void Import(IQuery _inteface)
        {
            _inteface.Import(connection, _inteface + ".csv");
        }
    }
}