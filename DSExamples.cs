using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    public class DSExamples
    {
        /*
         * Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
         * Example1:Input: nums = [1, 2, 3, 3] Output: true
         * Example2:Input: nums = [1, 2, 3, 4] Output: false
         * A HashSet<T> in C# is a collection that stores unique elements and provides fast lookups, insertions, and deletions.
         * It's part of the System.Collections.Generic namespace.
        */

        public bool HasDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }

    }
}
