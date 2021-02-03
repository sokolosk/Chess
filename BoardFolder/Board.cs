
namespace Chess_Console.BoardFolder

{
    public class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        
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

        public Piece piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];
        }

        public bool ThereIsPiece(Position pos)
        {
            ValidatePosition(pos);
            return piece(pos) != null;
        }

        public void InsertPiece(Piece p, Position pos)
        {
            if (ThereIsPiece(pos))
            {
                throw new BoardException("There is already a piece in this position! ");
            }
            Pieces[pos.Line, pos.Column] = p;
            p.position = pos;
        }

        public bool ValidPosition(Position pos)
        {
            if(pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
