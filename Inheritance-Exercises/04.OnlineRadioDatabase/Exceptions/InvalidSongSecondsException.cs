namespace _04.OnlineRadioDatabase.Exceptions
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException()
            : base()
        {
        }

        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }
    }
}
