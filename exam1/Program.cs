using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    internal class Program
    {
        static void Main()
        {
            int n = 5;

            while (true)
            {
                int cube = n * n * n;
                string key = GetSortedNumbers(cube);

                // Счетчик для найденных кубов с одинаковыми цифрами
                int count = 0;
                int smallestCube = int.MaxValue;

                // Проверяем все предыдущие кубы
                for (int i = 1; i < n; i++)
                {
                    int earlyCube = i * i * i;
                    // Проверяем, является ли предыдущий куб кубом и совпадают ли отсортированные цифры
                    if (IsItCube(earlyCube) && GetSortedNumbers(earlyCube) == key)
                    {
                        count++;
                        smallestCube = Math.Min(smallestCube, earlyCube);
                    }
                }

                // Учитываем текущий куб
                count++;
                smallestCube = Math.Min(smallestCube, cube);

                // Если количество кубов равно 3, выводим результат
                if (count == 3)
                {
                    Console.WriteLine($"Наименьший куб, перестановки цифр которого дают ровно три куба: {smallestCube}");
                    break;
                }

                n++;
            }
        }

        // Метод для получения отсортированных цифр числа в виде строки
        static string GetSortedNumbers(int number)
        {
            char[] numbers = number.ToString().ToCharArray();
            Array.Sort(numbers);
            return new string(numbers);
        }

        // Метод для проверки, является ли число кубом
        static bool IsItCube(int number)
        {
            int cuber = (int)Math.Round(Math.Pow(number, 1.0 / 3.0));
            return cuber * cuber * cuber == number;
        }
    }

}


