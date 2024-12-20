using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона (например, c1):");
            var whiteBishopPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного ферзя (например, d8):");
            var blackQueenPosition = Console.ReadLine();

            if (IsWhiteBishopUnderAttack(whiteBishopPosition, blackQueenPosition))
            {
                Console.WriteLine("Слон не может находиться под боем");
                Console.ReadKey();
                return;

            }
            Console.WriteLine("Введите позицию хода белого слона:");
            var move = Console.ReadLine();

            Console.WriteLine(IsWhiteBishopMoveCorrect(whiteBishopPosition, move, blackQueenPosition));
            Console.ReadKey();
        }
        static bool IsWhiteBishopUnderAttack(string whiteBishopPosition, string blackQueenPosition)
        {
            return CanQueenAttack(blackQueenPosition, whiteBishopPosition);
        }
        static bool CanQueenAttack(string queenPosition, string position)
        {
            int qRow, qColumn, pRow, pColumn;
            DecodePosition(queenPosition, out qColumn, out qRow);
            DecodePosition(position, out pColumn, out pRow);

            return qRow == pRow || qColumn == pColumn ||
                   Math.Abs(qRow - pRow) == Math.Abs(qColumn - pColumn);
        }
        static bool IsWhiteBishopMoveCorrect(string whiteBishopPosition, string move, string blackQueenPosition)
        {
            int wbRow, wbColumn, mRow, mColumn;
            DecodePosition(whiteBishopPosition, out wbColumn, out wbRow);
            DecodePosition(move, out mColumn, out mRow);

            return Math.Abs(wbRow - mRow) == Math.Abs(wbColumn - mColumn) &&
                   !CanQueenAttack(blackQueenPosition, move);
        }
        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 'a' + 1; 
            row = int.Parse(position[1].ToString());
        }
    }
}
