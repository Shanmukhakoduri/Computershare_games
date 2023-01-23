using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShare_GuessNumber
{
    internal class GuessNumberGame : IGame
    {
        static int Guess = 0;
        static int Target = 5;
        static string Input = "";
        static Random RandomNumber = new Random();

        public void Play()
        {
            Target = RandomNumber.Next(10) + 1;
            Console.Write("~~~ Guess what number I am thinking of (should be between 1 to 10)----  ");
            Input = Console.ReadLine();
            if (int.TryParse(Input, out Guess))
            {
                if (Guess == Target)
                {
                    Console.WriteLine("Congratulations! You guessed " + Guess + " and the number I was thinking of was " + Target + ".");
                }
                else
                {
                    Console.WriteLine("Too bad. You guessed " + Guess + " and the number I was thinking of was " + Target + ". Try again!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Play();
            }
        }
    }
}
