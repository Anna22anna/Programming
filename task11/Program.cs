using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива (1 <= n <= 20):");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 20)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите действительное число V");
            double v;
            if (!double.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Ошибка ввода числа V");
                Console.ReadKey();
                return;
            }

            var numbers = new double[n];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Math.Pow(v, i) * Math.Pow(Math.E, -1 * v) / Factorial(i);

            PrintArray(numbers);
            ReplaceArray(numbers);
            PrintArray(numbers);
            Console.WriteLine($"Сумма модулей разностей i-1 и i+1: {CalculateSumOfProducts(numbers):F3}");
            PrintArray(Get(numbers, v));

            Console.ReadKey();
        }
        static void ReplaceArray(double[] array)
        {
            double sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum = array[i] + array[i - 1];
                array[i] = sum;
            }

        }
        static double CalculateSumOfProducts(double[] array)
        {
            double result = 0;
            for (int i = 1; i < array.Length; i++) 
            {
                result += Math.Abs(array[i] - array[i - 1]);
            }
            return result;
        }

        static double[] Get(double[] array, double a)
        {
            double[] result = new double[array.Length];
            for (int i = 0;i < array.Length; i++)
            {
                result[i] = array[i] - a;
            }
        return result;
        }

        static double Factorial(int number)
        {
            if (number == 0) return 1;
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        static void PrintArray(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item:F3} ");
            }
            Console.WriteLine();
        }
    }

}
