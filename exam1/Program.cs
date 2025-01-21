using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            while (true)
            {
                int cube = n * n * n;
                string sort = GetSortedNumbers(cube);
                int count = 0;
                int rightCube = int.MaxValue;

                for (int i = 1; i < n; i++)
                {
                    int earlyCube = i * i * i;

                    if (IsItCube(earlyCube) && GetSortedNumbers(earlyCube) == sort)
                    {
                        count++;
                        rightCube = Math.Min(rightCube, earlyCube);
                    }
                }

                count++;
                rightCube = Math.Min(rightCube, cube);

                if (count == 3)
                {
                    Console.WriteLine($"Наименьший куб:{rightCube}");
                    break;
                }
                n++;
            }
            Console.ReadKey();
        }

        static string GetSortedNumbers(int number)
        {
            char[] numbers = number.ToString().ToCharArray();
            Array.Sort(numbers);
            return new string(numbers);
        }

        static bool IsItCube(int number)
        {
            int cuber = (int)Math.Round(Math.Pow(number, 1.0 / 3.0));
            return cuber * cuber * cuber == number;
        }
    }
}

