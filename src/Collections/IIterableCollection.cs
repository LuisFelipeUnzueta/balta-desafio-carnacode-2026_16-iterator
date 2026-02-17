using IteratorPattern.Iterators;
using IteratorPattern.Models;

namespace IteratorPattern.Collections;

/// <summary>
/// Interface for an aggregate (collection) that can create iterators.
/// Part of the Iterator pattern (Aggregate part).
/// </summary>
public interface IIterableCollection
{
    IIterator<Song> CreateSequentialIterator();
    IIterator<Song> CreateShuffleIterator();
    IIterator<Song> CreateGenreIterator(string genre);
}
