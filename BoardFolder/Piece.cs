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

        public Piece(Position position, Color color, Board board)
        {
            this.position = position;
            this.color = color;
            this.Movements = 0;
            this.board = board;
        }
    }
}
