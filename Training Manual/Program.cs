using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            ushort year = Convert.ToUInt16(Console.ReadLine());
            //bool leap = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? true : false;
            Console.WriteLine("Введите кол-во дней (от 1 до 365):");
            short days = Convert.ToInt16(Console.ReadLine());
            if (1 <= days && days <= 365)
            {  
                Console.WriteLine(new DateTime(year, 1, 1).AddDays(days).ToString());
            }
            else
            {
                Console.WriteLine("Неправильный формат кол-ва дней");
            }
            Console.ReadKey();
        }
    }
}
