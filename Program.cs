using System;
using Chess_Console.BoardFolder;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int line, column;
            line = 2;
            column = 3;

            Position posicao = new Position(line, column);
            Board board = new Board(8, 8);

            Console.WriteLine(board);
        }
    }
}
