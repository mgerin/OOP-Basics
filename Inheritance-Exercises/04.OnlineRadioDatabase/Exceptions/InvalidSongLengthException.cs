namespace _04.OnlineRadioDatabase.Exceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException()
            : base()
        {  
        }

        public InvalidSongLengthException(string message)
            : base(message)
        {
        }
    }
}
