using System;
namespace Chess_Console.BoardFolder
{
    public class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int Movements { get; set; }
        public Board board { get; set; }

        public Piece()
        {
        }

        public Piece(Board board, Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            this.Movements = 0;
            
        }
    }
}
