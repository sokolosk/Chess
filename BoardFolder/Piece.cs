using System;
namespace Chess_Console.BoardFolder
{
    public class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int Movements { get; protected set; }
        public Board board { get; protected set; }

        
        public Piece(Board board, Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            this.Movements = 0;
            
        }

        public void IncrementMovement()
        {
            Movements++;
        }
    }
}
