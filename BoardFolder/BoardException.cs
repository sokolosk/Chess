using System;

namespace Chess_Console
{
    public class BoardException : Exception
    {
        public BoardException(string msg) : base(msg)
        {

        }
    }
}
