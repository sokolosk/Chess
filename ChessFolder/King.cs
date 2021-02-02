using System;
using Chess_Console.BoardFolder;

namespace Chess_Console.ChessFolder
{
    public class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
