using System;
using CLI;

namespace AutoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = string.Empty;
            do
            {
                Show.Menu();
                key = Convert.ToString(Console.ReadLine());
                if (key == "5")
                {
                    Console.WriteLine("До свидания");
                    return;
                }

                Menu._Menu(key);
            } while (key != "5");
        }
    }
}