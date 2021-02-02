using System;
using Chess_Console.BoardFolder;

namespace Chess_Console.ChessFolder
{
    public class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}