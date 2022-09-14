using System.Collections.Generic;
using System;

namespace MyMath
{
    /// <summary> creating an operations class </summary>
    public class Operations
    {
        /// <summary> creating an operations class </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            int max = nums[0];
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
    }
}