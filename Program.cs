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
                ChessGame game = new ChessGame();

                Screen.PrintBoard(game.board);

            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            
            Console.ReadLine();

        }
    }
}
