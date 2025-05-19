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

        /*
         * Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
         * An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
         * Example1:Input: s = "racecar", t = "carrace" Output: true
         * Example2:Input: s = "jar", t = "jam" Output: false
         * In C#, a HashMap is typically referred to as a Dictionary<TKey, TValue>, and it provides a collection of key-value pairs.
         * Each key must be unique, and the associated value can be of any data type.
         * Internally, a hash table is used to store the data, providing fast lookups for retrieving values based on their keys.
         */
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<string, int> sMap = new Dictionary<string, int>();
            Dictionary<string, int> tMap = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                sMap[s[i].ToString()] = 1 + sMap.GetValueOrDefault(s[i].ToString(), 0);
                tMap[t[i].ToString()] = 1 + tMap.GetValueOrDefault(t[i].ToString(), 0);
            }

            foreach (var key in sMap.Keys)
            {
                if (!tMap.ContainsKey(key) || sMap[key] != tMap[key])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
