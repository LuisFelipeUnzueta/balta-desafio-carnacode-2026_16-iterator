using IteratorPattern.Models;

namespace IteratorPattern.Iterators;

/// <summary>
/// Concrete Iterator that filters the collection by a specific genre.
/// </summary>
public class GenreIterator : IIterator<Song>
{
    private readonly List<Song> _filteredSongs;
    private int _position = -1;

    public GenreIterator(List<Song> songs, string genre)
    {
        _filteredSongs = songs.Where(s => s.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public Song Current => _filteredSongs[_position];

    public bool MoveNext()
    {
        if (_position < _filteredSongs.Count - 1)
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
