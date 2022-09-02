using System;
using System.Collections.Generic;
// class List with more Hashing
class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
	// hashthat
        List<int> alienz = new List<int>();
        foreach (int xyz in list1)
        {
            if (!list2.Contains(xyz))
                alienz.Add(xyz);
        }
        foreach (int xyz in list2)
        {
            if (!list1.Contains(xyz))
                alienz.Add(xyz);
        }
	// sort
        alienz.Sort();
        return alienz;
    }
}
