using System;
using Chess_Console.BoardFolder;
using Chess_Console.ChessFolder;

namespace Chess_Console
{
    public class Screen
    {
        public static void PrintBoard(Board board)
        {
            for(int i=0; i< board.Lines; i++)
            {
                for(int j=0; j<board.Columns; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(board.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
