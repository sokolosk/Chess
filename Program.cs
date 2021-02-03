using System;
using Chess_Console.BoardFolder;
using Chess_Console.ChessFolder;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.InsertPiece(new Tower(board, Color.black), new Position(0, 0));
                board.InsertPiece(new Tower(board, Color.black), new Position(0, 7));
                board.InsertPiece(new King(board, Color.black), new Position(0, 4));

                Screen.PrintBoard(board);

            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            ChessPosition pos = new ChessPosition('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosition());
            Console.ReadLine();

        }
    }
}
