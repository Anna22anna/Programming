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
            Console.WriteLine("Введите число n:");
            double n = double.Parse(Console.ReadLine());
            double P = 1.29 * Math.Pow(Math.E, -1 * (1.25 * Math.Pow(10, -4)) * 100);
            Console.WriteLine(P);
            Console.ReadKey();

            string[] headers = { "Высота", "Плотность", "Возраст" };

            // Данные для таблицы
            string[,] data = {
            { "1", "Алексей", "25" },
            { "2", "Мария", "30" },
            { "3", "Иван", "22" }
        };

            // Печать заголовков
            PrintRow(headers);

            // Печать разделительной линии
            PrintLine(headers.Length);

            // Печать данных
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string[] row = new string[headers.Length];
                for (int j = 0; j < headers.Length; j++)
                {
                    row[j] = data[i, j];
                }
                PrintRow(row);
            }
        }

        static void PrintRow(string[] row)
        {
            Console.WriteLine("| " + string.Join(" | ", row) + " |");
        }

        static void PrintLine(int columnCount)
        {
            Console.WriteLine(new string('-', columnCount * 10));
        }
    }
}

