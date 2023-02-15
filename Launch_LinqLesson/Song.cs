using System;

namespace Launch_LinqLesson
{
    public class Song
    {
        public string Title { get; set; }
        public int PlayCount { get; set; }
        public int Length { get; set; }
        public Artist Artist { get; set; }

        public Song(Artist artist, string title, int length, int playCount)
        {
            Artist = artist;
            Title = title;
            Length = length;
            PlayCount = playCount;
        }
    }
}
