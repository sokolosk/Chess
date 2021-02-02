using System;
using Chess_Console.Board;

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

            Console.WriteLine(posicao);
        }
    }
}
