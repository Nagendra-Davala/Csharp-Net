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
                    if (i != strings.Length - 2) continue;
                    Console.WriteLine("Consecutive");
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
    }
}
