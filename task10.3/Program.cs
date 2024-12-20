using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников");
            int s;

            if (!CorrectWrite(out s))
            {
                Console.ReadKey();
                return;
            }

            int sum;
            sum = 0;
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Введите зарплату сотрудника:");

                int salary;
                if (!CorrectWrite(out salary))
                {
                    Console.ReadKey();
                    return;
                }
                sum += salary;
            }
            Console.WriteLine($"Сумма зарплат всех сотрудников: {sum}");
            Console.ReadKey();
        }
        static bool CorrectWrite(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int s))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = s;
            return true;
        }
    }
}
