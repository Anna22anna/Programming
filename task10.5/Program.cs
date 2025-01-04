using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число:"); string rad = Console.ReadLine();
            if (!int.TryParse(rad, out int number))
            {
                Console.WriteLine("Ошибка: Введите корректное натуральное число.");
                return;
            }
            var Sum = 0;
            int position = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (position % 2 == 0)
                {
                    Sum += digit;
                }
                else
                {
                    Sum -= digit;
                }

                number /= 10;
                position++;
            }
            Console.WriteLine($"Знакочередующаяся сумма цифр: {Sum}");
            Console.ReadKey();
        }
    }
}
