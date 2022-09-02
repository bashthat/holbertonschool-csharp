using System;
using System.Collections.Generic;
class List
{
    // Main Method
    public static int Sum(List<int> myList) {
        
        int x, y, z;
        x - y - z = 0;

        myList.Sort();
        foreach (int my in myList) {
            if (my == x) {
                continue;
            }
            else if (my == y) {
                continue;
            }
            else if (my == z) {
                continue;
            }
            else {
                x = y;
                y = z;
                z = my;
            }
        }
    }
}