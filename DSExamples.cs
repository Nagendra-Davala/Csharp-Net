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


        /*
         * Given an integer array nums and an integer k, return the k most frequent elements within the array.
         * The test cases are generated such that the answer is always unique.You may return the output in any order.
         * Example1:Input: nums = [1,2,2,3,3,3], k = 2 Output: [2,3]
         * Example2: Input: nums = [7,7], k = 1 Output: [7]
         * BucketSort Algorithem
         */
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (!count.ContainsKey(i))
                {
                    count[i] = 1;
                }
                else
                {
                    count[i] = 1 + count[i];
                }
            }

            List<int>[] bucket = new List<int>[nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            foreach (var i in count)
            {
                bucket[i.Value].Add(i.Key);
            }

            List<int> result = new List<int>();
            for (int i = nums.Length; i >= 0 && result.Count < k; i--)
            {
                foreach (int num in bucket[i])
                {
                    result.Add(num);
                    if (result.Count == k)
                    {
                        break;
                    }

                }
            }

            return result.ToArray();
        }


        /*
         * Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.
         * Please implement encode and decode
         * Example:Input: ["neet","code","love","you"] Output:["neet","code","love","you"]
         */

        public string Encode(IList<string> strs)
        {
            string res = "";
            foreach (string s in strs)
            {
                res += s.Length + "#" + s;
            }

            return res;
        }

        public List<string> Decode(string s)
        {
            List<string> result = new List<string>();
            int j = 0;
            int previous = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == '#')
                {
                    int count = int.Parse(s.Substring(previous, i - previous));
                    string subString = s.Substring(i + 1, count);
                    result.Add(subString);
                    i = i + count + 1;
                    previous = i;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }

        /*
         * Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].
         * Input: nums = [1,2,4,6] Output: [48,24,12,8]
         * Input: nums = [-1,0,1,2,3] Output: [0,-6,0,0,0]
         */
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix = prefix * nums[i];
            }
            int postfix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = postfix * result[i];
                postfix = postfix * nums[i];
            }
            return result;
        }

    }
}
