/*
 *1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    internal class ArraysAndLists
    {
        public void GetHowManyLikesyouRecevied()
        {
            List<string> list = new List<string>();
            string friendName = string.Empty;
            do
            {
                friendName = Console.ReadLine() ?? string.Empty;
                if (!string.IsNullOrEmpty(friendName))
                {
                    list.Add(friendName);
                }
            }
            while (!string.IsNullOrWhiteSpace(friendName));

            if (list.Count == 1)
            {
                Console.WriteLine("{0} likes your profile", list[0]);
            }
            if (list.Count >= 3)
            {
                Console.WriteLine("{0},{1} and {2} others like your profile", list[0], list[1], list.Count - 2);
            }
            if (list.Count == 2)
            {
                Console.WriteLine("{0},{1} like your profile", list[0], list[1]);
            }
        }


        public void ReverseOfaName()
        {
            Console.WriteLine("Please enter your number");
            string name = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(name)) { return; }
            char[] chars = name.ToCharArray();
            string reverseOfString = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseOfString += chars[i];
            }
            Console.WriteLine(reverseOfString);
            // Array.Reverse(chars);
        }

        public void SortNumbers()
        {
            Console.WriteLine("Please enter 5 numbers");
            int[] ints = new int[5];
            int inputNumber = 0;
            int temp = 0;
            for (int i = 0; i < 5; i++)
            {
                inputNumber = Convert.ToInt32(Console.ReadLine());
                while (ints.Contains(inputNumber))
                {
                    Console.WriteLine("You have already entered this '{0}' Nunber..Please re-try", inputNumber);
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                }

                ints[i] = inputNumber;
            }
            //9,1,3,4,5
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (ints[i] > ints[j])
                    {
                        temp = ints[j];
                        ints[j] = ints[i];
                        ints[i] = temp;
                    }
                }
            }

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }

        public void uniqueNumbers()
        {
            Console.WriteLine("Please enter number or Quit");
            List<int> numbers = new List<int>();
            string input = Console.ReadLine() ?? string.Empty;
            int number = 0;
            while (!string.IsNullOrWhiteSpace(input) && !input.Equals("Quit"))
            {
                number = Convert.ToInt32(input);
                if (numbers.Count >= 0 && !numbers.Contains(number))
                {
                    numbers.Add(number);
                }

                Console.WriteLine("Please enter number or Quit");
                input = Console.ReadLine() ?? string.Empty;
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Execution stopped");
        }

        public void SmallestNumbersInTheList()
        {
            List<int> numbers = new List<int>();
            bool retry = false;
            do
            {
                if (retry)
                {
                    Console.WriteLine("InvalidList");
                }
                string commaSeparatedNumbers = Console.ReadLine() ?? string.Empty;
                var list = commaSeparatedNumbers.Split(',');

                foreach (string i in list)
                {
                    numbers.Add(Convert.ToInt32(i));
                }

                if (numbers.Count <= 5) retry = true;
                else retry = false;
            } while (retry);

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            for (int i = 0; i <= numbers.Count-1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
