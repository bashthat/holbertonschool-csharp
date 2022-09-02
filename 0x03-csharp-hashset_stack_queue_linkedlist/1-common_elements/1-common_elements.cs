using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> dynamic =  new List<int>();
        foreach (int xyz in list1)
        {
            if (list2.Contains(xyz))
                dynamic.Add(xyz);
        }
        return dynamic;
    }
}
