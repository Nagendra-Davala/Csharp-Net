using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    internal class Loop
    {
        public int CountOfNumbersDivisibleByThree() 
        { 
            int count = 0;
            foreach (var i in Enumerable.Range(2, 99))
            {
                if ( i%3 == 0 ) count++;
            }
            return count; 
        }

        public int CountOfNumbersOfPreviousEnteredNumbers()
        {
            Console.WriteLine( "Please enter a \"number\" or  \"Ok\" to exit.");
            string input = Console.ReadLine() ?? string.Empty;
            int count = 0;
            while (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out int output))
                {
                    count += output;
                    Console.WriteLine("Please enter a \"number\" or  \"Ok\"");
                    input = Console.ReadLine() ?? string.Empty;
                }
                else if (!input.Equals("Ok"))
                {
                    Console.WriteLine("You have entered  Wrong, Please enter a \"number\" or  \"Ok\"");
                    input = Console.ReadLine() ?? string.Empty;
                } 
                else
                {
                    break;
                }
            }

            return count;
        }

        public int FactorialOfNumber(int number)
        {
            if(number == 0) return 1;

            return number  * FactorialOfNumber(number - 1);
        }

        public void GuessRandomNumber()
        {
            var random = new Random();
            var input = random.Next(1, 10);
            //Console.WriteLine(input);
            Console.WriteLine("-------------Guess the Number between 1 to 10 ----------------");
            Console.WriteLine("Enter the number: ");
            int chances = 1;
            for (int i = 0; i < 4; i++)
            {
                
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == input)
                {
                    Console.WriteLine("You Won!!! ");
                    break;
                }
                else if (chances < 4)
                {
                    Console.WriteLine("Guess the number again");
                }
                chances++;
            }

            if(chances > 4)
             Console.WriteLine("YOU LOST, The Number is {0}", input);
        }

        public void sumOfCommaSeparatedNumbers()
        {
            var commaSeparatedNumbers = Console.ReadLine();
            int total = 0;
            var str = commaSeparatedNumbers.Split(',');
            foreach (var number in str)
            {
                total = total + Convert.ToInt32(number.ToString());
            }
            
            //foreach(char ch in commaSeparatedNumbers.ToString())
            //{
            //    if (ch == ',') continue;
            //    total = total + Convert.ToInt32(ch.ToString());

            //}
            Console.WriteLine("Total Comma separated numbers are: {0}", total);

        }
    }
}
