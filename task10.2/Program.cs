using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников в компании:");
            double n;
            if (!TryInputNumber(out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода."); Console.ReadKey();
                return;
            }
            double totalSalary = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите зарплату сотрудника {i + 1}:");
                double salary;
                if (!TryInputNumber(out salary) || salary < 0)
                {
                    Console.WriteLine("Ошибка ввода. Зарплата должна быть неотрицательным числом."); Console.ReadKey();
                    return;
                }
                totalSalary += salary;
            }
            Console.WriteLine($"Общая сумма выплаченных зарплат составляет: {totalSalary:F2} руб.");
            Console.ReadKey();
        }
        static bool TryInputNumber(out double number)
        {
            number = 0; if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            return true;
        }
    }
}
