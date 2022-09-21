using System;

/// <summary>
/// Class Queue implementation
/// </summary>

class Queue<T>
{
    /// <summary>
    /// Check type of Queue
    /// </summary>
    /// <returns>Queue Type</returns>

    public Type CheckType()
    {
        return typeof(T);
    }
}
