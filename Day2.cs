using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    public class Day2
    {
        public void IsPositiveOrNegativeOrZero()
        {
            Console.WriteLine("Enter a number to check whether it is positive, Negative or zero.");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) 
            {
                Console.WriteLine($"{number} is a Positive Integer.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a Negative Integer.");
            }
            else
            {
                Console.WriteLine($"{number} is a Zero.");
            }
           
        }

        public void IsVowelOrConsonant()
        {
            Console.WriteLine("Enter a character to check it is vowel or consonant.");
            var character = Convert.ToChar(Console.ReadKey().KeyChar);
            if ("aeiouAEIOU".Contains(character)) 
            {
                Console.WriteLine($"{character} is vowel");
            }
            else
            {
                Console.WriteLine($"{character} is Consonants");
            }
        }

        public void CountOfDigitsInNumber() 
        {
            Console.WriteLine("Enter a number to count number of digits.");
            var originalNumber = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(originalNumber);
            int count = 0;
            while (number > 0) 
            {
                number /= 10;
                count++;
            }
            Console.WriteLine($"Count of digits in {originalNumber} : {count}");
        }

        public void ReverseNumber()
        {
            Console.WriteLine("Enter a number to reverse number of digits.");
            var originalNumber = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(originalNumber);
            int reverseNumber = 0;
            while (number > 0)
            {
                reverseNumber = (number % 10) + (reverseNumber * 10);
                number /= 10;
            }

            if(originalNumber < 0)
            {
                reverseNumber *= -1;
            }
            Console.WriteLine($"reverse of digits in {originalNumber} : {reverseNumber}");
        }

        public void SumOfDigitsInNumber()
        {
            Console.WriteLine("Enter a number to sum number of digits.");
            var originalNumber = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(originalNumber);
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine($"Sum of digits in {originalNumber} : {sum}");
        }
    }
}
