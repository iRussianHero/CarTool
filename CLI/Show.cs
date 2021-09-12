using System;
using DataBaseLib;

namespace CLI
{
    public class Show
    {
        public static void PrintYelloy(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public static void Menu()
        {
            PrintYelloy("1. Действия с водителями");
            PrintYelloy("2. Действия с автомобилями");
            PrintYelloy("3. Действия с сервисом");
            PrintYelloy("4. Дополнительные функции");
            PrintYelloy("5. Завершение программы");
        }

        public static void SubMenu1()
        {
            PrintYelloy("1 Показать всех водителей");
            PrintYelloy("2 Ввод данных водителя");
            PrintYelloy("3 Экспорт данных водителей");
            PrintYelloy("4 Импорт данных водителей");
            PrintYelloy("0 Назад");
        }

        public static void SubMenu2()
        {
            PrintYelloy("1 Показать все автомобили");
            PrintYelloy("2 Ввод данных автомобиля");
            PrintYelloy("3 Экспорт данных автомобиля");
            PrintYelloy("4 Импорт данных автомобиляй");
            PrintYelloy("0 Назад");
        }

        public static void SubMenu3()
        {
            PrintYelloy("1 Показать сервисную информацию");
            PrintYelloy("2 Ввод данных об обслуживании");
            PrintYelloy("3 Экспорт данных об обслуживании");
            PrintYelloy("4 Импорт данных об обслуживании");
            PrintYelloy("0 Назад");
        }

        public static void SubMenu4()
        {
            Show.PrintYelloy("1 Проверка состояния Автомобиля");
            Show.PrintYelloy("2 Проверка пробега по Водителю");
            Show.PrintYelloy("0 Назад");
        }
    }
}