using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>Initializes Class Shape</summary>

class Obj
{
    /// <summary>Represents a method</summary>
    /// <param name="myObj">Object to be checked</param>
    /// <returns>True if object is an instance</returns>
    
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var prop in myObj.GetType().GetProperties())
            Console.WriteLine(prop.Name);
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var meth in myObj.GetType().GetMethods())
            Console.WriteLine(meth.Name);
    }
}