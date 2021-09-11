using System;

namespace CLI
{
    public class Show
    {
        public static void Menu()
        {
            Console.WriteLine("1. Действия с водителями");
            Console.WriteLine("2. Действия с автомобилями");
            Console.WriteLine("3. Действия с сервисом");
            Console.WriteLine("4. Дополнительные функции");
            var key = Convert.ToChar(Console.ReadLine());
            switch (key)
            {
                case '1':
                    SubMenu1();
                    break;
                case '2':
                    SubMenu2();
                    break;
                case '3':
                    SubMenu3();
                    break;
                case '4':
                    SubMenu4();
                    break;
                default:
                    Console.WriteLine("Введен некорректный символ");
                    break;
            }

            static void SubMenu1()
            {
                Console.WriteLine("1 Показать всех водителей");
                Console.WriteLine("2 Ввод данных водителя");
                Console.WriteLine("3 Экспорт данных водителей");
                Console.WriteLine("4 Импорт данных водителей");
                Console.WriteLine("0 Назад");
                var key = Convert.ToChar(Console.ReadLine());
                switch (key)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '0':
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Введен некорректный символ");
                        break;
                }
            }

            static void SubMenu2()
            {
                Console.WriteLine("1 Показать все автомобили");
                Console.WriteLine("2 Ввод данных автомобиля");
                Console.WriteLine("3 Экспорт данных автомобиля");
                Console.WriteLine("4 Импорт данных автомобиляй");
                Console.WriteLine("0 Назад");
                var key = Convert.ToChar(Console.ReadLine());
                switch (key)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '0':
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Введен некорректный символ");
                        break;
                }
            }
            static void SubMenu3()
            {
                Console.WriteLine("1 Показать сервисную информацию");
                Console.WriteLine("2 Ввод данных об обслуживании");
                Console.WriteLine("3 Экспорт данных об обслуживании");
                Console.WriteLine("4 Импорт данных об обслуживании");
                Console.WriteLine("0 Назад");
                var key = Convert.ToChar(Console.ReadLine());
                switch (key)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '0':
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Введен некорректный символ");
                        break;
                }
            }
            static void SubMenu4()
            {
                Console.WriteLine("1 Проверка состояния Автомобиля");
                Console.WriteLine("2 Проверка пробега по Водителю");
                Console.WriteLine("0 Назад");
                var key = Convert.ToChar(Console.ReadLine());
                switch (key)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '0':
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Введен некорректный символ");
                        break;
                }
            }
        }
    }
}