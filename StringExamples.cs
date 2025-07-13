/*
 Note: For all these exercises, ignore input validation unless otherwise specified. Assume the user provides input in the format that the program expects.

1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
 */
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    public class StringExamples
    {
        public void IsConsecutiveNumbers()
        {
            Console.WriteLine("Please enter number separated by hyphen");
            string input = Console.ReadLine() ?? string.Empty;
            if(string.IsNullOrWhiteSpace(input)) Console.WriteLine("Input connot be nulll");
            string[] strings = input.Split('-');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                int firstNumber = int.Parse(strings[i]);
                int secondNumber = int.Parse(strings[i + 1]);
                if (firstNumber - secondNumber == 1 || firstNumber - secondNumber == -1)
                {
                    if (i == strings.Length - 2) 
                      Console.WriteLine("Consecutive");
                    else
                        continue;
                }
                else
                {
                    Console.WriteLine("Non Consecutive");
                    break;
                }

            }

        }

        public void AreDupliactesAvailable()
        {
            Console.WriteLine("Please enter number separated by hyphen");
            string input = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input)) Environment.Exit(0);
            string[] strings = input.Split('-');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                for (int j = i+1; j <= strings.Length - 1; j++)
                {
                    if (!(strings[i] == strings[j])) continue;
                    Console.WriteLine("Duplicates");
                    break;
                }
            }

        }

        public void ValidateTime()
        {
            Console.WriteLine("Please enter time in 24 format");
            string input = Console.ReadLine() ?? string.Empty;
            string[] strings = input.Split(":");
            if(strings.Length != 2) Console.WriteLine( "Invalid");
            int hour = Convert.ToInt32(strings[0]);
            int minute = Convert.ToInt32(strings[1]);
            if((hour >= 0 && hour < 24)  && (minute >= 0 && minute < 60))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ConvertToPascalCase()
        {

            Console.WriteLine("Please enter words separated by Space");
            string input = Console.ReadLine() ?? string.Empty;
            string[] strings = input.Split(" ");
            string pasclName = string.Empty;
            foreach (string s in strings)
            {
               string word = char.ToUpper(s[0]) + s.ToLower().Substring(1);
                pasclName += word;
            }
            Console.WriteLine(pasclName);
        }

        public void ReverseString()
        {
            Console.WriteLine("Please enter a String");
            string input = Console.ReadLine() ?? string.Empty;
            for (int j = input.Length-1; j >=0 ; j--)
            {
                Console.Write(input[j]);
            }

        }

        public void IsPalindrome()
        {
            Console.WriteLine("Please enter a String");
            string input = Console.ReadLine() ?? string.Empty;
            bool isPalindrome = true;
            for ( int j = input.Length-1, i=0; j >= input.Length/2 ; i++,j--)
            {
                if(input[j] != input[i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Palindrome");
            } else {
                Console.WriteLine("No a palindrome");

            }
        }

        public void ReversrOfString()
        {
            Console.WriteLine("Please enter a String");
            string input = Console.ReadLine() ?? string.Empty;
            var words = input.Split(' ');
            for (int j = words.Length-1; j >=0; j--) {
                Console.Write(words[j]);
                Console.Write(' ');

            }
        }

        public void ReverseEachWord()
        {
            Console.WriteLine("Please enter a String");
            string str = Console.ReadLine() ?? string.Empty;
            int start = 0;
            for (int j = 0; j < str.Length; j++) {

                if (str[j] == ' ') {
                    int i = j - 1;
                    while (i >= start)
                    {
                        Console.Write(str[i]);
                        i--;
                    }
                    start = j + 1;
                    Console.Write(' ');
                }
            }

            for (int j = str.Length - 1; j >= start; j--) { 
                Console.Write(str[j]);
            }

        }

        public  void ReverseWordOrder()
        {
            Console.WriteLine("Please enter a String");
            string str = Console.ReadLine() ?? string.Empty;
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }

        public void CountTheCharacters()
        {
            Console.WriteLine("Please enter a String");
            string str = Console.ReadLine() ?? string.Empty;
            Dictionary<char, int> charactersCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!charactersCount.ContainsKey(c))
                {
                    charactersCount[c] = 1;
                }
                else
                {
                    charactersCount[c]++;
                }
            }
            foreach (var n in charactersCount)
            {
                Console.WriteLine("{0} repeated {1} times", n.Key , n.Value);
            }
        }

        public void RemoveDuplicates()
        {
            Console.WriteLine("Please enter a String");
            string str = Console.ReadLine() ?? string.Empty;
            string nonDuplicateString = string.Empty;
            for(int i=0; i<str.Length; i++)
            {
                if (nonDuplicateString.Contains(str[i]))
                {
                    continue;
                }

                nonDuplicateString += str[i];
            }

            Console.WriteLine(nonDuplicateString);
        }

        public void AllPossibleSubStrings()
        {
            Console.WriteLine("Please enter a String");
            string str = Console.ReadLine() ?? string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; j++)
                {
                    stringBuilder.Append(str[j]);
                    Console.Write(stringBuilder + " ");
                }
            }
        }

        public void RemoveDuplicates(ref char[] str, ref int length)
        {
            if (length == 0 || length == 1)
                return;

            int index = 0; // Position for unique characters

            for (int i = 0; i < length; i++)
            {
                bool isDuplicate = false;

                // Check if str[i] appeared before in str[0...index-1]
                for (int j = 0; j < index; j++)
                {
                    if (str[i] == str[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If not duplicate, add to the new position
                if (!isDuplicate)
                {
                    str[index] = str[i];
                    index++;
                }
            }

            // Adjust length of the string
            length = index;
        }

        public string ReverseRecursive(string s)
        {
            //var reverseString = new string(s.Reverse().ToArray());
            //Console.WriteLine("vowelsCount:{0}", input3.Count(c => "aeiouAEIOU".Contains(c))); Count Vowels
            if (s.Length <= 1) return s;
            return ReverseRecursive(s.Substring(1)) + s[0];
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char> {{ ')', '(' }, { ']', '[' }, { '}', '{' } };

            foreach (char c in s)
            {
                if (pairs.ContainsValue(c))
                    stack.Push(c);
                else if (pairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[c])
                        return false;
                }
            }
            return stack.Count == 0;
        }

    }
}
