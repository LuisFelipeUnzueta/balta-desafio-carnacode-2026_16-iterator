namespace IteratorPattern.Iterators;

/// <summary>
/// Generic interface for the Iterator pattern.
/// Defines the methods required to traverse a collection.
/// </summary>
/// <typeparam name="T">The type of elements to iterate over.</typeparam>
public interface IIterator<T>
{
    /// <summary>
    /// Gets the current element in the iteration.
    /// </summary>
    T Current { get; }

    /// <summary>
    /// Advances the iterator to the next element of the collection.
    /// </summary>
    /// <returns>True if the iterator was successfully advanced; false if the iterator has passed the end of the collection.</returns>
    bool MoveNext();

    /// <summary>
    /// Sets the iterator to its initial position, which is before the first element in the collection.
    /// </summary>
    void Reset();
}
