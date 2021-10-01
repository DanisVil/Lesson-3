using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    enum Bukvi { a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8};
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c, d;
            Console.WriteLine("Введите а, b, c, d в отдельных строках");
            a = Convert.ToByte(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            c = Convert.ToByte(Console.ReadLine());
            d = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Фигура стоит на поле {(Bukvi)a}{b}, интересующее нас поле - {(Bukvi)c}{d}");

            if (a == c || b == d)
            {
                Console.WriteLine("Ладья угрожает полю");
            }
            else
            {
                Console.WriteLine("Ладья не угрожает полю");
            }

            if (Math.Abs(a - c) == Math.Abs(b - d))
            {
                Console.WriteLine("Слон угрожает полю");
            }
            else
            {
                Console.WriteLine("Слон не угрожает полю");
            }

            if (a == c &&  Math.Abs(b - d) <= 1 || b == d && Math.Abs(a - c) <= 1 || Math.Abs(a - c) == Math.Abs(b - d) && Math.Abs(b - d) == 1)
            {
                Console.WriteLine("Король может дойти до поля за 1 ход");
            }
            else
            {
                Console.WriteLine("Король не может дойти до поля за 1 ход");
            }

            if (a == c || b == d || Math.Abs(a - c) == Math.Abs(b - d))
            {
                Console.WriteLine("Ферзь угрожает полю");
            }
            else
            {
                Console.WriteLine("Ферзь не угрожает полю");
            }

            if (a == c && d - b == 1 || b == 2 && d - b == 2)
            {
                Console.WriteLine("Белая пешка может пройти на поле");
            }
            else if (Math.Abs(a - c) == 1 && d - b == 1)
            {
                Console.WriteLine("Белая пешка может побить поле");
            }
            else
            {
                Console.WriteLine("Белая пешка не может попасть на поле");
            }


            if (a == c && d - b == -1 || b == 7 && d - b == -2)
            {
                Console.WriteLine("Черная пешка может пройти на поле");
            }
            else if (Math.Abs(a - c) == 1 && d - b == -1)
            {
                Console.WriteLine("Черная пешка может побить поле");
            }
            else
            {
                Console.WriteLine("Черная пешка не может попасть на поле");
            }

            if (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1 || Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2)
            {
                Console.WriteLine("Конь угрожает полю");
            }
            else
            {
                Console.WriteLine("Конь не угрожает полю");
            }

            Console.ReadKey();
        }
    }
}
