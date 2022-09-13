using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> Class Obj </summary>

class Obj
{
    /// <summary> Initializes a new instance of the <see cref="Obj"/> class. </summary>
    /// <param name="derivedType"> Object to be checked. </param>
    /// <param name="baseType"> Object to be checked. </param>
    /// <returns> True or False. </returns>

    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}