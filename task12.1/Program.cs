using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число m (5 < m < 20)");
            int m;
            if (!TryInputNumber(out m))
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число n (5 < n < 20)");
            int n;
            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (m < 5 || m > 20 || n < 5 || n > 20)
            {
                Console.WriteLine("Числа не удовлетворяют неравенству.");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);
            PrintMatrix(matrix);

            Console.WriteLine();

            var (columnIndex1, rowIndex1, columnIndex2, rowIndex2) = GetIndexOfColumnWithMinimalLastElement(matrix);

            Console.WriteLine($"Элемент с индексами({columnIndex1}, {rowIndex1}) > элемента с индексами({columnIndex2}, {rowIndex2})");
            Console.WriteLine();

            var sum = GetSum(matrix);

            for (int i = 0; i < sum.Length; i++)
                Console.WriteLine($"Строка {i} - сумма чётных элементов равна {sum[i]}");
        }
        static bool TryInputNumber(out int number)
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
                    Console.Write($"{matrix[i,j],2} ");

                Console.WriteLine();
            }
        }

        static (int j, int i, int jj, int ii) GetIndexOfColumnWithMinimalLastElement(int[,] matrix)
        {
            var columnIndex1 = -1;
            var rowIndex1 = -1;
            var columnIndex2 = -1;
            var rowIndex2 = -1;

            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                var isBadColumn = true;
                for (var i = 0; i < matrix.GetLength(0) - 1; i++)
                    if (matrix[i, j] > matrix[i + 1, j])
                    {
                        columnIndex1 = j;
                        rowIndex1 = i;
                        columnIndex2 = j;
                        rowIndex2 = i + 1;
                        isBadColumn = false;
                        break;
                    }

                if (!isBadColumn)
                {
                    break;
                }
            }

            return (columnIndex1, rowIndex1, columnIndex2, rowIndex2);
        }

        static int[] GetSum(int[,] matrix)
        {
            var result = new int[matrix.GetLength(0)];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                    int evenSum = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] % 2 == 0)
                        {
                            evenSum += matrix[i, j];
                        }
                    }

                result[i] = evenSum;
            }

            return result;
        }
    }
}
