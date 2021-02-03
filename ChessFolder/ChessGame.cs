using System;
using Chess_Console.BoardFolder;

namespace Chess_Console.ChessFolder
{
    public class ChessGame
    {
        public Board board { get; private set; }
        private int turn;
        private Color player;

        public ChessGame()
        {
            board = new Board(8, 8);
            turn = 1;
            player = Color.white;
            InsertPieces();

        }

        public void Move(Position start, Position destiny)
        {
            Piece p = board.RemovePiece(start);
            p.IncrementMovement();
            Piece capturedPiece = board.RemovePiece(destiny);
            board.InsertPiece(p, destiny);
        }

        private void InsertPieces()
        {
            board.InsertPiece(new King(board, Color.black), new ChessPosition( 'c', 4).ToPosition());
            board.InsertPiece(new King(board, Color.black), new ChessPosition('c', 5).ToPosition());
            board.InsertPiece(new King(board, Color.black), new ChessPosition('c', 6).ToPosition());
            board.InsertPiece(new King(board, Color.black), new ChessPosition('c', 7).ToPosition());
            board.InsertPiece(new Tower(board, Color.black), new ChessPosition('b', 1).ToPosition());

            board.InsertPiece(new Tower(board, Color.white), new ChessPosition('a', 4).ToPosition());
            board.InsertPiece(new Tower(board, Color.white), new ChessPosition('b', 5).ToPosition());
            board.InsertPiece(new King(board, Color.white), new ChessPosition('d', 6).ToPosition());
            board.InsertPiece(new King(board, Color.white), new ChessPosition('e', 7).ToPosition());
            board.InsertPiece(new Tower(board, Color.white), new ChessPosition('f', 1).ToPosition());


        }
    }
}
