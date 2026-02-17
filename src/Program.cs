using IteratorPattern.Collections;
using IteratorPattern.Iterators;
using IteratorPattern.Models;

namespace IteratorPattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Iterator Pattern Challenge - Music Playlist ===");

        var myPlaylist = new Playlist("My Favorites 2026");
        myPlaylist.AddSong(new Song("Bohemian Rhapsody", "Queen", "Rock", 354, 1975));
        myPlaylist.AddSong(new Song("Imagine", "John Lennon", "Pop", 183, 1971));
        myPlaylist.AddSong(new Song("Smells Like Teen Spirit", "Nirvana", "Rock", 301, 1991));
        myPlaylist.AddSong(new Song("Billie Jean", "Michael Jackson", "Pop", 294, 1982));
        myPlaylist.AddSong(new Song("Hotel California", "Eagles", "Rock", 391, 1976));
        myPlaylist.AddSong(new Song("Sweet Child O' Mine", "Guns N' Roses", "Rock", 356, 1987));

        // 1. Sequential Iteration
        PlayPlaylist(myPlaylist.CreateSequentialIterator(), "Sequential");

        // 2. Shuffle Iteration
        PlayPlaylist(myPlaylist.CreateShuffleIterator(), "Shuffle (Random)");

        // 3. Genre-based Iteration (Rock)
        PlayPlaylist(myPlaylist.CreateGenreIterator("Rock"), "Genre: Rock");

        // 4. Genre-based Iteration (Pop)
        PlayPlaylist(myPlaylist.CreateGenreIterator("Pop"), "Genre: Pop");

        // "\n=== Implementation Details ==="
        // "✓ Collection structure (List<Song>) is fully encapsulated."
        // "✓ Iteration logic is separated from the collection."
        // "✓ Multiple traversal strategies (Sequential, Shuffle, Genre) are supported."
        // "✓ The client interacts with the collection through generic iterators."
    }

    /// <summary>
    /// Demonstrates how the client can iterate over different types of iterators
    /// using a uniform interface.
    /// </summary>
    static void PlayPlaylist(IIterator<Song> iterator, string method)
    {
        Console.WriteLine($"\n--- Playing Playlist ({method}) ---");
        int count = 1;
        while (iterator.MoveNext())
        {
            Console.WriteLine($"{count++}. {iterator.Current}");
        }
    }
}
