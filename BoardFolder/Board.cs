using System;
using Chess_Console.ChessFolder;
namespace Chess_Console.BoardFolder

{
    public class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board()
        {
        }

        public Board(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            Pieces = new Piece[lines, columns];
        }

        public Piece piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public void InsertPiece(Piece p, Position pos)
        {
            Pieces[pos.Line, pos.Column] = p;
            p.position = pos;
        }
    }
}
