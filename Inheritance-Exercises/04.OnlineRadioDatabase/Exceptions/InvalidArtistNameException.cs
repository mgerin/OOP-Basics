namespace _04.OnlineRadioDatabase.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
            : base()
        {   
        }

        public InvalidArtistNameException(string message)
            : base(message)
        {
        }
    }
}
