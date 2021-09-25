using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("task1");
            //Console.WriteLine("Введите число:");

            //Console.WriteLine("task2");
            //Console.WriteLine("Введите а:");
            //byte window_a = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Введите b:");
            //byte window_b = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Введите диаемтр головы d:");
            //byte head_diametr = Convert.ToByte(Console.ReadLine());
            //if (head_diametr <= window_a - 2 && head_diametr <= window_b - 2)
            //{
            //    Console.WriteLine("Вася может высунуть голову");
            //}
            //else
            //{
            //    Console.WriteLine("Вася не может высунуть голову");
            //}

            //Console.WriteLine("task3");
            //Console.WriteLine("Введите номер дня недели:");
            //switch (Convert.ToByte(Console.ReadLine()))
            //{
            //    case 1: 
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;

            //    default:
            //        Console.WriteLine("Нет такого дня недели");
            //        break;
            //}

            Console.WriteLine("task4");
            Console.WriteLine("Введите номер карты:");
            switch (Convert.ToByte(Console.ReadLine()))
            {
                case 6:
                    Console.WriteLine("шестерка");
                    break;
                case 7:
                    Console.WriteLine("семерка");
                    break;
                case 8:
                    Console.WriteLine("восьмерка");
                    break;
                case 9:
                    Console.WriteLine("девятка");
                    break;
                case 10:
                    Console.WriteLine("десятка");
                    break;
                case 11:
                    Console.WriteLine("валет");
                    break;
                case 12:
                    Console.WriteLine("дама");
                    break;
                case 13:
                    Console.WriteLine("король");
                    break;
                case 14:
                    Console.WriteLine("туз");
                    break;

                default:
                    Console.WriteLine("Нет такой карты");
                    break;
            }

            Console.WriteLine("task5");
            ushort earth_radius = 6370;


            Console.ReadKey();
        }
    }
}
