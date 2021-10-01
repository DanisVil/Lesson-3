using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        enum MouthSize { small, wide };
        static void Main(string[] args)
        {
            Console.WriteLine("task1.1\nВведите число:");
            float abs_num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Модуль числа равен {Math.Sqrt(abs_num * abs_num)}");

            Console.WriteLine("task1.2\nВведите первое число:");
            float first_num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            float second_num = Convert.ToSingle(Console.ReadLine());
            if (first_num * first_num - second_num * second_num > 0)
            {
                first_num /= 2;
            }
            Console.WriteLine(first_num);

            Console.WriteLine("task1.3\nВведите название животного:");
            MouthSize frog_mouth = MouthSize.wide;
            if (Console.ReadLine().ToLower() == "аллигатор")
            {
                frog_mouth = MouthSize.small;
            }
            Console.WriteLine(frog_mouth);

            Console.WriteLine("task1.4");
            try
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with Alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politician":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Несовершеннолетним вход запрещен");
                Console.WriteLine(ex);
            }

            Console.WriteLine("task1.5\nВведите строку:");
            string english_check = Console.ReadLine().ToLower();
            if (english_check.Contains("english"))
            {
                Console.WriteLine("О вы из Англии");
            }
            else
            {
                Console.WriteLine("В строке нет подстроки \"english\"");
            }

            Console.WriteLine("task2.1");
            float quotient = 3, quotient3 = quotient * quotient * quotient, quotient9 = quotient3 * quotient3 * quotient3;
            Console.WriteLine((1 - 1 / quotient9) / (1 - 1 / quotient));

            Console.WriteLine("task2.2");
            float harmonic_series = 0, alternating_harmonic_series = 0;
            for (int i = 1; i <= 100; i++)
            {
                harmonic_series += (float)1 / i;
                alternating_harmonic_series += (float)Math.Pow(-1, i + 1) / i;
            }
            Console.WriteLine($"Расстояние до дома = {alternating_harmonic_series}, путь = {harmonic_series}");

            Console.WriteLine("task2.3");
            float jan_precipitation = 0, march_precipitation = 0;
            var rand = new Random();
            for (int i = 1; i <= 31; i++)
            {
                jan_precipitation += rand.Next(50, 201) / 100;
                march_precipitation += rand.Next(50, 201) / 100;
            }
            Console.WriteLine($"Среднее кол-во дневных осадков за январь = {jan_precipitation / 31}, март = {march_precipitation / 31}");

            Console.WriteLine("task 3.1");
            double numerator1 = 1, numerator2 = 2, denominator1 = 1, denominator2 = 1, sum_num, sum_denom;
            while (Math.Abs(numerator2 / denominator2 - numerator1 / denominator1) > 0.001)
            {
                sum_num = numerator1 + numerator2;
                sum_denom = denominator1 + denominator2;
                numerator1 = numerator2;
                denominator1 = denominator2;
                numerator2 = sum_num;
                denominator2 = sum_denom;
            }
            Console.WriteLine($"{numerator2} / {denominator2}");

            Console.WriteLine("task3.2\nВведите число");
            uint aboba = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine((Math.Floor(Math.Sqrt(aboba)) + 1) * (Math.Floor(Math.Sqrt(aboba)) + 1));

            Console.WriteLine("task3.3");
            for (int i = 100; i >= 80; i--)
            {
                Console.WriteLine(i);
            }
            byte j = 100;
            do
            {
                Console.WriteLine(j);
                j--;
            } while (j >= 80);

            Console.WriteLine("task3.4");
            Console.WriteLine(Math.Floor(5000f / 39f) * 39);

            Console.WriteLine("task3.5");
            for (byte i = 1; i <= 5; i++)
            {
                for (byte k = 1; k <= i; k++) 
                {
                    Console.Write("5 "); 
                }
                Console.WriteLine();
            }

            for (byte i = 1; i <= 5; i++)
            {
                for (byte k = 1; k <= 6 - i; k++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
