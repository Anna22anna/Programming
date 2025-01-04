using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число k (2 < k < 10): "); int k = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше b.");
                return;
            }
            if (k <= 2 || k >= 10)
            {
                Console.WriteLine("Ошибка: k должно быть в диапазоне от 3 до 9.");
                return;
            }

            Console.WriteLine($"Числа от {a} до {b}, сумма делителей которых кратна {k}:"); for (int i = a; i <= b; i++)
            {
                int sumOfDivisors = SumOfDivisors(i);
                if (sumOfDivisors % k == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int SumOfDivisors(int n)
        {
            int sum = 0; for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
