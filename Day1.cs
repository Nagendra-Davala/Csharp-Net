using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Net
{
    public class Day1
    {
        public void SumOfTwoNumbers()
        {
            var number1 = Convert.ToInt32(Console.ReadLine());
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum : {number1}+ {number2} = {number1 + number2}");
        }
        public void IsCharExistInString() 
        {
            var inputString = Console.ReadLine();
            var inputChar = Console.ReadKey().KeyChar;
            if (inputString != null && inputString.Contains(Convert.ToChar(inputChar)))
            {
                Console.WriteLine($"{inputChar} exists in {inputString}");
            }
        }
        public void PrintTriangle()
        {
            Console.WriteLine("Enter a number");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

   
}
