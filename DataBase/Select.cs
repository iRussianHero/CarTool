namespace DataBaseLib
{
    public class Select
    {
        public static void Driver(ConnectionDB db)
        {
            db.Open();
            
            db.Close();
        }
        ////в это классе пишем только SELECT запросы
    }
}