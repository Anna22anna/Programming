using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person mike;
            mike = new Person();
            mike.name = "Джонни";
            mike.lastName = "Депп";
            mike.SetAge(56);

            var kate = new Person() { name = "Тони", lastName = "Старк" };
            kate.SetAge(58);

            mike.PrintInfo();
            kate.PrintInfo();
            Console.ReadKey();
        }
    }
}
