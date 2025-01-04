using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n (10 <= n <= 100):"); int n;
            if (!TryInputNumber(out n)  || n < 10 || n > 100)
            { 
                Console.WriteLine("Ошибка ввода. Число должно быть в диапазоне от 10 до 100.");
                Console.ReadKey(); return;
            }
            Console.WriteLine("Высота (м) | Плотность (кг/м)"); Console.WriteLine("--------------------------");
            for (int h = 0; h <= n * 100; h += 100)
            {
                double density = 1.29 * Math.Pow(Math.E, 0.000125 * -1 * h);
                Console.WriteLine($"{h,10} | {density:F2}");
            }
            Console.ReadKey();
        }
        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода"); return false;
            }
            number = n; return true;
        }
    }
}
