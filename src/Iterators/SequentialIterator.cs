using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

/// <summary>
/// Concrete Iterator that traverses the collection sequentially.
/// </summary>
public class SequentialIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _position = -1;

    public SequentialIterator(List<Song> songs)
    {
        _songs = songs;
    }

    public Song Current => _songs[_position];

    public bool MoveNext()
    {
        if (_position < _songs.Count - 1)
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
