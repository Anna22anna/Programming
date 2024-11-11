using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона");
            var whitePawnPosition = Console.ReadLine();

            if (IsPownPositionIncorrect(whitePawnPosition))
            {
                Console.WriteLine("Белый слон не может стоять на чёрной клетке");

                Console.ReadKey();
                return;
            }
            Console.WriteLine("Введите позицию черного ферзя");
            var blackPawnPosition = Console.ReadLine();

            if (IsWhitePownCanStrike(whitePawnPosition, blackPawnPosition))
            {
                Console.WriteLine("Одна из фигур находится под боем");

                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию хода белого слона");
            var move = Console.ReadLine();

            Console.WriteLine(IsWhitePownMoveCorrect(whitePawnPosition, move, blackPawnPosition));



            Console.ReadKey();
        }

        static bool IsPownPositionIncorrect(string pawnPosition)
        {
            int column, row;
            DecodePosition(pawnPosition, out column, out row);

            return (row == 1 || row == 3 || row == 5 || row == 7) && (Math.Abs(column) == 1 || Math.Abs(column) == 3 || Math.Abs(column) == 5 || Math.Abs(column) == 7) 
                || (row == 2 || row == 4 || row == 6 || row == 8) && (Math.Abs(column) == 2 || Math.Abs(column) == 4 || Math.Abs(column) == 6 || Math.Abs(column) == 8);
        }

        static bool IsWhitePownCanStrike(string whitePawnPosition, string position)
        {
            int wpRow, wpColumn, pRow, pColumn;

            DecodePosition(whitePawnPosition, out wpColumn, out wpRow);
            DecodePosition(position, out pColumn, out pRow);

            return wpRow == pRow - 1 && Math.Abs(wpColumn - pColumn) == 1 
                || wpRow == pRow - 2 && Math.Abs(wpColumn - pColumn) == 2
                || wpRow == pRow - 3 && Math.Abs(wpColumn - pColumn) == 3
                || wpRow == pRow - 4 && Math.Abs(wpColumn - pColumn) == 4
                || wpRow == pRow - 5 && Math.Abs(wpColumn - pColumn) == 5
                || wpRow == pRow - 6 && Math.Abs(wpColumn - pColumn) == 6
                || wpRow == pRow + 1 && Math.Abs(wpColumn - pColumn) == 1
                || wpRow == pRow + 2 && Math.Abs(wpColumn - pColumn) == 2
                || wpRow == pRow + 3 && Math.Abs(wpColumn - pColumn) == 3
                || wpRow == pRow + 4 && Math.Abs(wpColumn - pColumn) == 4
                || wpRow == pRow + 5 && Math.Abs(wpColumn - pColumn) == 5
                || wpRow == pRow + 6 && Math.Abs(wpColumn - pColumn) == 6;
        }

        static bool IsBlackPownCanStrike(string blackPawnPosition, string position)
        {
            int bpRow, bpColumn, pRow, pColumn;

            DecodePosition(blackPawnPosition, out bpColumn, out bpRow);
            DecodePosition(position, out pColumn, out pRow);

            return bpRow == pRow + 1 && Math.Abs(bpColumn - pColumn) == 1
                || bpRow == pRow + 2 && Math.Abs(bpColumn - pColumn) == 2
                || bpRow == pRow + 3 && Math.Abs(bpColumn - pColumn) == 3
                || bpRow == pRow + 4 && Math.Abs(bpColumn - pColumn) == 4
                || bpRow == pRow + 5 && Math.Abs(bpColumn - pColumn) == 5
                || bpRow == pRow + 6 && Math.Abs(bpColumn - pColumn) == 6
                || bpRow == pRow - 1 && Math.Abs(bpColumn - pColumn) == 1
                || bpRow == pRow - 2 && Math.Abs(bpColumn - pColumn) == 2
                || bpRow == pRow - 3 && Math.Abs(bpColumn - pColumn) == 3
                || bpRow == pRow - 4 && Math.Abs(bpColumn - pColumn) == 4
                || bpRow == pRow - 5 && Math.Abs(bpColumn - pColumn) == 5
                || bpRow == pRow - 6 && Math.Abs(bpColumn - pColumn) == 6 
                || bpRow == pRow - 1
                || bpRow == pRow - 2
                || bpRow == pRow - 3
                || bpRow == pRow - 4
                || bpRow == pRow - 5
                || bpRow == pRow - 6
                || bpRow == pRow + 1
                || bpRow == pRow + 2
                || bpRow == pRow + 3
                || bpRow == pRow + 4
                || bpRow == pRow + 5
                || bpRow == pRow + 6 
                || Math.Abs(bpColumn - pColumn) == 1
                || Math.Abs(bpColumn - pColumn) == 2
                || Math.Abs(bpColumn - pColumn) == 3
                || Math.Abs(bpColumn - pColumn) == 4
                || Math.Abs(bpColumn - pColumn) == 5
                || Math.Abs(bpColumn - pColumn) == 6;
        }

        static bool IsWhitePawnCanMove (string whitePawnPosition, string move, string blackPawnPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whitePawnPosition, out wc, out wr);
            DecodePosition(blackPawnPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            var middlePosition = whitePawnPosition[0] +
                (int.Parse(whitePawnPosition[1].ToString()) + 1).ToString();

            return IsWhitePownMoveCorrect(whitePawnPosition, move, blackPawnPosition) &&
                IsBlackPownCanStrike(blackPawnPosition, move) &&
                !IsBlackPownCanStrike(blackPawnPosition, middlePosition);
        }

        static bool IsWhitePownMoveCorrect(
            string whitePawnPosition, string move, string blackPawnPosition)
        {
            int wr, wc, br, bc, mr, mc;

            DecodePosition(whitePawnPosition, out wc, out wr);
            DecodePosition(blackPawnPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            return (Math.Abs(wc - mc) == 1 
                || Math.Abs(wc - mc) == 2
                || Math.Abs(wc - mc) == 3
                || Math.Abs(wc - mc) == 4
                || Math.Abs(wc - mc) == 5
                || Math.Abs(wc - mc) == 6);
        }



        static void DecodePosition(string position, out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = int.Parse(position[1].ToString());
        }
    }
}
