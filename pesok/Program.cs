using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(!int.TryParse(Console.ReadLine(), out int n) || n < 1 || n > Math.Pow(10, 5)) 
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            string lastImpressiveString = string.Empty;
            int nuberOfImpressiveStrings = 0;

            for (int i = 0; i < n; i++)
            {

            }
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
