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
            Console.WriteLine("task1");
            Console.WriteLine("Введите трёхзначное число:");
            short palindrom = Convert.ToInt16(Console.ReadLine());
            if (palindrom / 100 == palindrom % 10)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }

            Console.WriteLine("task2");
            Console.WriteLine("Введите а:");
            byte window_a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите b:");
            byte window_b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите диаемтр головы d:");
            byte head_diametr = Convert.ToByte(Console.ReadLine());
            if (head_diametr <= window_a - 2 && head_diametr <= window_b - 2)
            {
                Console.WriteLine("Вася может высунуть голову");
            }
            else
            {
                Console.WriteLine("Вася не может высунуть голову");
            }

            Console.WriteLine("task3");
            Console.WriteLine("Введите номер дня недели:");
            switch (Convert.ToByte(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;

                default:
                    Console.WriteLine("Нет такого дня недели");
                    break;
            }

            try
            {
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
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Номер карты не может быть таким");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не номер карты");
            }

            Console.WriteLine("task5");
            ushort earth_radius = 6370;
            for (byte i = 1; i <= 10; i++)
            {
                Console.WriteLine("Расстояние до горизонта с высоты {0} км - {1}", i, Math.Sqrt(i * (2 * earth_radius + i)));
            }

            Console.WriteLine("task6\nВведите число:");
            int num_table = Convert.ToInt32(Console.ReadLine());
            for (byte i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num_table, i, num_table * i);
            }

            try
            {
                Console.WriteLine("task7");
                int sequence_num = Convert.ToInt32(Console.ReadLine());
                int sequence_sum = 0;
                ushort sequence_length = 0;
                while (sequence_num >= 0)
                {
                    sequence_sum += sequence_num;
                    sequence_length++;
                    sequence_num = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Среднее арифметическое = {0}", (float)sequence_sum / sequence_length);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Вы ввели слишком большое(маленькое) число");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели число неправильного формата");
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Console.WriteLine("task8");
            float temp_num = Convert.ToSingle(Console.ReadLine());
            float cur_num;
            bool increasing = true;
            for (byte i = 2; i <= 10; i++)
            {

                cur_num = Convert.ToSingle(Console.ReadLine());
                if (cur_num <= temp_num)
                {
                    Console.WriteLine("Число под номером {0} нарушает возрастающую последовательность", i);
                    increasing = false;
                    break;
                }
                temp_num = cur_num;
            }
            if (increasing)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию");
            }

            Console.WriteLine("task9");
            ushort iter = 1;
            long sum = 0;
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 0)
            {
                if (iter % 3 == 0)
                {
                    sum += input;
                }
                input = Convert.ToInt32(Console.ReadLine());
                iter++;
            }
            Console.WriteLine(sum);

            Console.WriteLine("task10");
            long sum10 = 0;
        Label:
            int input10 = Convert.ToInt32(Console.ReadLine());
            if (input10 != 0)
            {
                sum10 += input10;
                goto Label;
            }
            Console.WriteLine(sum10);

            Console.ReadKey();
        }
    }
}
