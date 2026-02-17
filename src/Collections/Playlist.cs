using IteratorPattern.Iterators;
using IteratorPattern.Models;

namespace IteratorPattern.Collections;

/// <summary>
/// Concrete Aggregate class that stores elements and creates iterators.
/// Highlights: Internal collection is private, exposing only the iterator interface.
/// </summary>
public class Playlist : IIterableCollection
{
    public string Name { get; }
    private readonly List<Song> _songs;

    public Playlist(string name)
    {
        Name = name;
        _songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    public IIterator<Song> CreateSequentialIterator()
    {
        return new SequentialIterator(_songs);
    }

    public IIterator<Song> CreateShuffleIterator()
    {
        return new ShuffleIterator(_songs);
    }

    public IIterator<Song> CreateGenreIterator(string genre)
    {
        return new GenreIterator(_songs, genre);
    }
}
