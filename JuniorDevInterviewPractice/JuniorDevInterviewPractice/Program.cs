using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorDevInterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classic FizzBuzz program
            /*
            int number = 100;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 7 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }
            */

            //Write a program that prints out only prime numbers
            /*
            for (int i = 1; i <= 100; i++)
            {
                int counter1 = 0;
                int counter2 = 0;
                for (int j = 2; j < i - 1; j++)
                {
                    int remainder = i % j;
                    if (remainder == 0)
                    {
                        counter1++;
                    }
                    else
                    {
                        counter2++;
                    }
                }
                if (counter1 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            */

            //Write a function that takes a string as input and returns the string reversed. 
            //The function should reverse the string in-place and return it as the return value of the function.

            Console.WriteLine("Please enter a word: ");
            string wordToArray = Console.ReadLine();

            char[] array = wordToArray.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine("Here's the word reversed: ");
            Console.WriteLine(array);

        }
    }
}