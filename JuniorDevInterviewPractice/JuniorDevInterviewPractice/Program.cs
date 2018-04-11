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
        { }

        static void FizzBussProgram()
        {
            //Classic FizzBuzz program

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
            //stop console from exiting after running
            Console.ReadLine();
        }

        static void PrimeNumbersPrintOut()
        {
            //Write a program that prints out only prime numbers

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
            //stop console from exiting after running
            Console.ReadLine();
        }

        static void WordReversal()
        {
            //Write a function that takes a string as input and returns the string reversed. 
            //The function should reverse the string in-place and return it as the return value of the function.

            Console.WriteLine("Please enter a word: ");
            string wordToArray = Console.ReadLine();

            char[] array = wordToArray.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine("Here's the word reversed: ");
            Console.WriteLine(array);

            //stop console from exiting after running
            Console.ReadLine();
        }


        static void DnaMirrorReversal()
        {
            //Write a function that creates a DNA complement. A complement matches "A" with "T", and "G" with "C". The complement is also a mirror image

            string dna = "AAAATTGCGCATGC";

            Console.WriteLine("The DNA string is: " + dna);

            char[] dnaLetters = dna.ToCharArray(); //translated dna strand to a character array
            int dnaLength = dnaLetters.Length; //got the length of the array to use in for loop

            List<string> dnaComplementLetters = new List<string>();

            for (int i = 0; i < dnaLength; i++)
            {
                char dnaLetter = dnaLetters[i];
                string dnaComplementLetter;

                //convert dnaLetter to a string to use in switch statement
                switch (dnaLetter.ToString())
                {
                    case "A":
                        dnaComplementLetter = "T";
                        dnaComplementLetters.Add(dnaComplementLetter);
                        break;
                    case "T":
                        dnaComplementLetter = "A";
                        dnaComplementLetters.Add(dnaComplementLetter);
                        break;
                    case "G":
                        dnaComplementLetter = "C";
                        dnaComplementLetters.Add(dnaComplementLetter);
                        break;
                    case "C":
                        dnaComplementLetter = "G";
                        dnaComplementLetters.Add(dnaComplementLetter);
                        break;
                    default:
                        Console.WriteLine("Invalid letter in dna string");
                        break;
                }
            }

            dnaComplementLetters.Reverse();

            //convert list<> into string
            string complementDna = String.Join("", dnaComplementLetters);

            Console.WriteLine("The new complement DNA string: " + complementDna);
            //stop console from exiting after running
            Console.ReadLine();
        }
    }
}
