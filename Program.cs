using System;
using Chess_Console.BoardFolder;
using Chess_Console.ChessFolder;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.InsertPiece(new Tower(board, Color.black), new Position(0, 0));
            board.InsertPiece(new Tower(board, Color.black), new Position(1, 3));
            board.InsertPiece(new King(board, Color.black), new Position(2, 4));

            Screen.PrintBoard(board); 
            //Console.ReadLine();

        }
    }
}
