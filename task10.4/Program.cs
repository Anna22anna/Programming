using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            int n;
            if (!CorrectWrite(out n))
            {
                Console.ReadKey();
                return;
            }
            int sum;
            int number;
            sum = 0;
            for (int i = 1; i < n; i++)
            {
                number = 
            }

            Console.WriteLine(sum);
        }
        static bool CorrectWrite(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }
    }
}
