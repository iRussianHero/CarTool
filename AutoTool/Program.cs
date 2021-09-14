using System;
using System.Collections.Generic;
using System.Diagnostics;
using CLI;
using DataBaseLib;

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

                Menu.SubMenu(key);
            } while (key != "5");
        }
    }
}