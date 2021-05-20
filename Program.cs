using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementExercise4
{
    class Program
    {
        //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost". 
        static void Main(string[] args)
        {
            var number = new Random().Next(1, 10);

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number between 1 and 10, you have 4 chances... ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You guessed the secret number!");
                    return;
                }
            }
            Console.WriteLine("You couldn't guess the number!");
            Console.WriteLine("The secret number is " + number);
        }
    }
}
