using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите последовательность целых чисел через пробел:"); string input = Console.ReadLine();
            string[] numberStrings = input.Split(' ');
            int evenCount = 0;
            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    if (number % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }
            Console.WriteLine($"Количество четных чисел: {evenCount}"); Console.ReadKey();
        }
    }
}
