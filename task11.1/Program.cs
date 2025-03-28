using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11._1
{
    internal class Program
    {
      static void Main(string[] args)
            {
                Console.WriteLine("Введите число элементов массива");

                int n;

                if (!int.TryParse(Console.ReadLine(), out n) || n > 20)
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    return;
                }

            Console.WriteLine("Введите действительное число V");
            
            var v = double.Parse(Console.ReadLine());

            var numbers = new double[n];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Math.Pow(v, i) * Math.Pow(Math.E, -1 * v) / Factorial(i);

            PrintArray(numbers);
            NormalizeArray(numbers);
            PrintArray(numbers);
            Console.WriteLine($"Сумма модулей разностей i-1 и i+1 равна {CalculalateSumOfProducts(numbers):F3}");

            PrintArray(GetAveragePartialSquaresSums(numbers));

                Console.ReadKey();
            }
            static void NormalizeArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }
            
        }
            static double CalculalateSumOfProducts(double[] array)
            {
            double result = 0;

            for (int i = 1; i < array.Length - 1; i++)
            { 
                result += Math.Abs(array[i] - array[i - 1]);
                result += Math.Abs(array[i] - array[i + 1]);
            }


            return result;
        }

            static double[] GetAveragePartialSquaresSums(double[] array)
            {
                if (array.Length == 0)
                    return new double[0];

                double[] result = new double[array.Length];
                double partialSum = 0;

                for (var k = 0; k < array.Length; k++)
                {
                    partialSum += array[k] * array[k];
                    result[k] = partialSum / (k + 1);
                }

                return result;
            }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element:F3} ");

            Console.WriteLine();
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
    }
}
  