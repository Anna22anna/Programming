using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию слона:");
            var whiteBishopPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию ферзя:");
            var blackQueenPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию хода слона:");
            var whiteBishopMove = Console.ReadLine();


            Console.ReadKey();
        }
        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }

        static bool IsBlackQueenCanStrike(string blackQueenPosition, string position)
        {

        }
        static bool IsWhiteBishopCanMove(string whiteBishopPosition, string whiteBishopMove, string blackQueenPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whiteBishopPosition, out wc, out wr);
            DecodePosition(blackQueenPosition, out bc, out br);
            DecodePosition(whiteBishopMove, out mc, out mr);

            var middlePosition = whiteBishopPosition[0] + (int.Parse(whiteBishopPosition[1].ToString()) + 1).ToString();

        }

    }
}
