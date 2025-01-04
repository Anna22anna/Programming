using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:"); int n;
            if (!TryInputNumber(out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода.");
                Console.ReadKey(); return;
            }
            int a = 1;
            int b = 1; int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += a;
                int next = a + b; a = b;
                b = next;
            }
            Console.WriteLine($"Сумма всех чисел Фибоначчи, не превосходящих {n}, равна {sum}");
            Console.ReadKey();
        }
        static bool TryInputNumber(out int number)
        {
            number = 0; if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = n;
            return true;
        }
    }
}
