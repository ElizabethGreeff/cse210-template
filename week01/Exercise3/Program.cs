using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the random number game!");
        Random randomNumber = new Random();
        int intRand = randomNumber.Next(1, 11);
        int guess = 0;

        while (guess != intRand)
        {
            Console.Write("What is your guess? ");
            string strGuess = Console.ReadLine();
            guess = int.Parse(strGuess);


            if (intRand > guess)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (intRand < guess)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine($"You got it! The nummber was: {intRand}");
            }
        }
    }
}