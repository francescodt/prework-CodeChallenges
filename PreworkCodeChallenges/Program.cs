using System;
using System.Net.Http.Headers;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayScore();

        }

        public static void ArrayScore()
        {
            int[] userArray = new int[5];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Please enter a number between 1-10");
                int userEntry = int.Parse(Console.ReadLine());

                if (userEntry > 10 || userEntry < 1)
                {
                    Console.WriteLine("No. Stop that.");
                    i--;
                }
                else
                {
                    userArray[i] = userEntry;
                }
            }

            Console.WriteLine(string.Join(", ", userArray));
            Console.WriteLine("Select a number from the array.");

            int userAnswer = int.Parse(Console.ReadLine());
            int counter = 0;

            foreach (int number in userArray)
            {
                if (userAnswer == number)
                {
                    counter++;
                }
            }

            Console.WriteLine(userAnswer * counter);

        }

        public static void LeapYear()
        {
            Console.WriteLine("Enter a year to see if it was a leap year.");
            int userYear = int.Parse(Console.ReadLine());

            if (userYear % 4 == 0)
            {
                if (userYear % 100 == 0)
                {
                    if (userYear % 400 == 0)
                    {
                        Console.WriteLine("That is indeed a leap year.");
                    }
                    else
                    {
                        Console.WriteLine("That is not a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine("That is a leap year.");
                }
            }
            else
            {
                Console.WriteLine("That is a leap year.");
            }

        }

        private static void CorrectSequence(int[] array)
        {
            if (SumOfArray(array) == ProductOfArray(array))
            {
                Console.WriteLine("Yes");
            }
            else if (SumOfArray(array) != ProductOfArray(array))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var number in array)
                {
                    if (number < 0 )
                    {
                        Console.WriteLine("No");
                    }
                }
            }
        }

        private static int SumOfArray(int[] array)
        {
            int total = 0;

            foreach (var number in array)
            {
                total = total + number;
            }
            return total;
        }

        private static int ProductOfArray(int[] array)
        {
            int total = 1;

            foreach (var number in array)
            {
                total = total * number;
            }
            return total;
        }
    }
}
