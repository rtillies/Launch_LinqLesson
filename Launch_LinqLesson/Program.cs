

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

            List<Song> songs = new() { purpleRain, raspberryBeret, vogue, laIslaBonita, expressYourself,
                wildWildLife, burningDownTheHouse, lifeDuringWartime, andSheWas, heartOfGlass };

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

        // 2. Use Where to get all songs with more than 10 plays.

        // 3. Use Where to get all songs by Talking Heads with more than 10 plays.

    // Ordering Collections
        // 1. Use OrderBy to get a list of songs sorted by length.

        // 2. Use OrderBy to get a list of songs sorted by title.

        // 3. Use OrderBy to get a list of songs sorted by artist (alphabetically)

    // Counting
        // 1. Use Count to return the number of songs by Prince.

        // 2. Use count to return the number of songs longer than 320

    // Characteristics of the Collection
        // 1. Use Any to determine if any of the songs have exactly 100 plays.

        // 2. Use Any to determine if any song is by Blondie.

        // 3. Use Any and Contains to determine if any song title contains the letter 'z'.
        }
    }
}
