using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

/// <summary>
/// Concrete Iterator that traverses the collection in a random order (Shuffle).
/// </summary>
public class ShuffleIterator : IIterator<Song>
{
    private readonly List<Song> _shuffledSongs;
    private int _position = -1;

    public ShuffleIterator(List<Song> songs)
    {
        var random = new Random();
        _shuffledSongs = songs.OrderBy(_ => random.Next()).ToList();
    }

    public Song Current => _shuffledSongs[_position];

    public bool MoveNext()
    {
        if (_position < _shuffledSongs.Count - 1)
        {
            _position++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _position = -1;
    }
}
