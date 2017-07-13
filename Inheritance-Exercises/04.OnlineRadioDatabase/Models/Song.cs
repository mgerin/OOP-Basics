namespace _04.OnlineRadioDatabase.Models
{
    using System;

    using _04.OnlineRadioDatabase.Exceptions;

    public class Song
    {
        private string artistName;

        private string songName;

        private string songLength;

        public Song(string artistName, string songName, string songLength)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        private string ArtistName
        {
            get => this.artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                }

                this.artistName = value;
            }
        }

        private string SongName
        {
            get => this.songName;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
                }

                this.songName = value;
            }
        }

        private string SongLength
        {
            get => this.songLength;
            set
            {
                var timeArgs = value.Split(':');
                int minutes;
                int seconds;
                if (timeArgs.Length > 2 || !int.TryParse(timeArgs[0], out minutes) || !int.TryParse(timeArgs[1], out seconds))
                {
                    throw new InvalidSongLengthException("Invalid song length.");
                }

                if (minutes < 0 || minutes > 14)
                {
                    throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                }

                if (seconds < 0 || seconds > 59)
                {
                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                }

                this.songLength = value;
            }
        }

        public double GetSeconds()
        {
            return TimeSpan.Parse($"0:{this.SongLength}").TotalSeconds;
        }
    }
}