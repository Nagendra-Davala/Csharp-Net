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

        /*
         * Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.
         * You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
         * Return the answer with the smaller index first.
         * Example1:Input: nums = [3,4,5,6], target = 7 Output: [0,1]
         * Example2:Input: nums = [4,5,6], target = 10 Output: [0,2]
         * Example3:Input: nums = [5,5], target = 10 Output: [0,1]
         *  dif = target-arra[i] is the only number gives the target.
         *  Storing all the array elements with the index in the Dictionary.
         *  Validate or verify diff value present in the dictionary or not. if exists return the their indices.
         */
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int dif = target - nums[i];
                if (numsHash.ContainsKey(dif))
                {
                    return new int[] { numsHash[dif], i };
                }
                numsHash[nums[i]] = i;
            }

            return null;
        }

        /*
         * Given an array of strings strs, group all anagrams together into sublists. You may return the output in any order.
         * An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
         * Example1:Input: strs = ["act","pots","tops","cat","stop","hat"] Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]
         * Example2: Input: strs = ["x"] Output: [["x"]]
         * Example3:Input: strs = [""] Output: [[""]]
         * for string abc: charCountArray:[1,1,1,0,0,...]. it is key and finds the similar key. 
         * 
         */
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                int[] charCount = new int[26];
                foreach (char c in str)
                {
                    charCount[c - 'a']++;
                }
                string key = string.Join(",", charCount);

                if (!result.ContainsKey(key))
                {
                    result[key] = new List<string>();
                }

                result[key].Add(str);
            }

            return result.Values.ToList<IList<string>>();

        }

    }
}
