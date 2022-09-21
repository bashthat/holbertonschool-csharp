using Microsoft.Win32.SafeHandles;
using System;

namespace Generics
{
    /// <summary>Class Queue</summary>
    public class Queue<T>
    {
        /// <summary>Check type of Queue</summary>
        public Type CheckType()
        {
            return typeof(T);
        }
    }
}