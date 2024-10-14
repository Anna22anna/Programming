using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "программа";
            var word1 = s
                .Remove(6)
                .Remove(1, 4);

            word1 += s.Substring(1, 1);

            var word2 = ReverseString(s)
                .Remove(0, 7)
                .Remove(1);


            word2 += ReverseString(s).Substring(3, 1);
            word2 += s.Substring(6, 1);
            word2 += ReverseString(s).Substring(8, 1);
            word2 += ReverseString(s).Substring(3, 1);


            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine(ReverseString(s));

            Console.ReadKey();
        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
