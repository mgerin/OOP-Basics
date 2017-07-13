namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;

    class InvalidSongException : Exception
    {
        public InvalidSongException()
            : base()
        {
        }

        public InvalidSongException(string message)
            : base(message)
        {
        }
    }
}
