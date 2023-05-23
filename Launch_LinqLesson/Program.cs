using System.Runtime.Intrinsics.X86;

namespace Launch_LinqLesson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prince = new Artist("Prince");
            var talkingHeads = new Artist("Talking Heads");
            var blondie = new Artist("Blondie");
            var madonna = new Artist("Madonna");

            var purpleRain = new Song(prince, "Purple Rain", 345, 23);
            var raspberryBeret = new Song(prince, "Raspberry Beret", 432, 12);
            var vogue = new Song(madonna, "Vogue", 408, 62);
            var laIslaBonita = new Song(madonna, "La Isla Bonita", 325, 15);
            var expressYourself = new Song(madonna, "Express Yourself", 312, 33);
            var wildWildLife = new Song(talkingHeads, "Wild Wild Life", 345, 45);
            var burningDownTheHouse = new Song(talkingHeads, "Burning Down the House", 348, 10);
            var lifeDuringWartime = new Song(talkingHeads, "Life During Wartime", 264, 8);
            var andSheWas = new Song(talkingHeads, "And She Was", 340, 11);
            var heartOfGlass = new Song(blondie, "Heart of Glass", 343, 3);

            List<Song> songs =
                new()
                {
                    purpleRain,
                    raspberryBeret,
                    vogue,
                    laIslaBonita,
                    expressYourself,
                    wildWildLife,
                    burningDownTheHouse,
                    lifeDuringWartime,
                    andSheWas,
                    heartOfGlass
                };

            // Filtering Collections
            // 1. Use Where to get all songs for the artist Madonna, to get you started, here is how you would do it with foreach:
            var madonnaSongs = new List<Song>();
            foreach (var song in songs)
            {
                if (song.Artist == madonna)
                {
                    madonnaSongs.Add(song);
                }
            }

            var madonaSongsLinq = new List<Song>();
            Console.WriteLine("Madona Songs:"); // Expected Output:Vogue, La Isla Bonita, Express Yourself
            foreach (Song song in madonaSongsLinq)
            {
                Console.WriteLine(song.Title);
            }

            // 2. Use Where to get all songs with more than 10 plays.

            var songsPlayedMoreThan10Times = new List<Song>();
            Console.WriteLine("Songs Played More than 10 times:"); // Expected Output: Purple Rain, Raspberry Beret, Vogue, La Isla Bonita, Express Yourself, Wild Wild Life, And She Was
            foreach (Song song in songsPlayedMoreThan10Times)
            {
                Console.WriteLine(song.Title);
            }

            // 3. Use Where to get all songs by Talking Heads with more than 10 plays.
            var popularTalkingHeadsSongs = new List<Song>();
            Console.WriteLine("Popular Talking Heads Songs:"); // Expected Output:Wild Wild Life, And She Was
            foreach (Song song in popularTalkingHeadsSongs)
            {
                Console.WriteLine(song.Title);
            }

            // Ordering Collections
            // 1. Use OrderBy to get a list of songs sorted by length.
            var orderedByLength = new List<Song>();
            Console.WriteLine("Ordered By Length:"); // Expected Output: Life During Wartime, Express Yourself, La Isla Bonita... etc.
            foreach (Song song in orderedByLength)
            {
                Console.WriteLine(song.Title);
            }

            // 2. Use OrderBy to get a list of songs sorted by title.
            var orderedByTitle = new List<Song>();
            Console.WriteLine("Ordered By Title:"); // Expected Output: And She Was, Burning Down the House, Express Yourself... etc.
            foreach (Song song in orderedByTitle)
            {
                Console.WriteLine(song.Title);
            }

            // 3. Use OrderBy to get a list of songs sorted by artist (alphabetically)
            var orderedByArtist = new List<Song>();
            Console.WriteLine("Ordered By Artist:"); // Expected Output: Heart of Glass, Vogue, La Isla Bonita... etc.
            foreach (Song song in orderedByArtist)
            {
                Console.WriteLine(song.Title);
            }

            // Counting
            // 1. Use Count to return the number of songs by Prince.
            int numPrinceSongs = 0;
            Console.WriteLine("Number Of Prince Songs:"); //Expected Output: 2
            Console.WriteLine(numPrinceSongs);

            // 2. Use count to return the number of songs longer than 320
            int longSongs = 0;
            Console.WriteLine("Long Songs:"); //Expected Output: 8
            Console.WriteLine(longSongs);

            // Characteristics of the Collection
            // 1. Use Any to determine if any of the songs have exactly 100 plays.
            bool any100Plays = true;
            Console.WriteLine("Any 100 Plays:"); //Expected Output: false
            Console.WriteLine(any100Plays);

            // 2. Use Any to determine if any song is by Blondie.
            bool anyBlondie = true;
            Console.WriteLine("Any Blondie Songs:"); //Expected Output: true
            Console.WriteLine(anyBlondie);

            // 3. Use Any and Contains to determine if any song title contains the letter 'z'.
            bool anyZ = true;
            Console.WriteLine("Any Z:"); //Expected Output: false
            Console.WriteLine(anyZ);
        }
    }
}
