namespace _04.OnlineRadioDatabase.Exceptions
{
    class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            : base()
        {   
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }
    }
}
