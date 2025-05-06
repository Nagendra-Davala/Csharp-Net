// See https://aka.ms/new-console-template for more information
using C_.Net;

Console.WriteLine("Hello, World!");


StringExamples stringExamples = new StringExamples();
Console.Write("Enter a string: ");
string input = Console.ReadLine();

char[] str = input.ToCharArray();
int length = str.Length;

stringExamples.RemoveDuplicates(ref str, ref length);

// Print the modified string
Console.WriteLine("String after removing duplicates: " + new string(str, 0, length));
