using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n от 5 до 20");
            int n;
            if (!CorrectWritet(out n))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число m от 5 до 20");
            int m;

            if (!CorrectWrite(out m))
            {
                Console.ReadKey();
                return;
            }

            if (n < 5 || n > 20 || m < 5 || m > 20)
            {
                Console.WriteLine("Числа не соответсвтуют значению");
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for ( int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);
            }

            PrintMatrix(matrix);

            GetOutIndex(matrix);
            for (var j = 0; j < matrix.GetLength(1); j++)
                for (var i = 0; i < matrix.GetLength(0) - 1; i++)
                    Console.WriteLine($"Нарушение порядка в столбце {j}, строки {i} и {i + 1}: {matrix[i, j]}");

            var diff = GetMaxMin(matrix);
            for ( int i = 0;i < diff.Length; i++)
                Console.WriteLine($"Номер строки {i} - разность равна {diff[i]}");

            Console.ReadKey();
        }
        static bool CorrectWrite(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }
            number = m;
            return true;
        }
        static bool CorrectWritet(out int number)
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
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i,j], 2} ");
                Console.WriteLine();
            }
        }

        static int GetOutIndex(int[,] matrix)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                var isBadColumn = false;
                for (var i = 0; i < matrix.GetLength(0) - 1; i++)
                    if (matrix[i, j] > matrix[i + 1, j])
                    {
                        isBadColumn = true;
                        break;
                    }
                if (isBadColumn)
                {
                    return j;
                }
            }
            return -1;
        }
        static int[] GetMaxMin(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0)];

            for(var i = 0;i < matrix.GetLength(0); i++)
            {
                var min = int.MaxValue;
                var max = int.MinValue;

                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < min)
                        min = matrix[i,j];

                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
                result[i] = max - min;
            }
            return result;
        }
    }
}
