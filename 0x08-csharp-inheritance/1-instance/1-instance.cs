using System;
using System.Collections.Generic;

/// <summary>
/// Initializes Class Obj
/// </summary>

class Obj
{
    /// <summary>Represents a method</summary>
    /// <param name="obj">Object to be checked</param>
    /// <returns>True if object is an instance of a
    /// class that inherits from Array
    /// otherwise return false
    /// </returns>
    
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}