﻿using System.Collections.Generic;
using System;

class List {
    public static int MaxInteger(List<int> myList) {
        if (myList == null || myList.Count == 0) {
            return -1;
        }
        int max = myList[0];
        for (int i = 1; i < myList.Count; i++) {
            if (myList[i] > max) {
                max = myList[i];
            }
        }
        return max;
    }
}