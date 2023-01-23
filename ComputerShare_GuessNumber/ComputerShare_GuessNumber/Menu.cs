using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShare_GuessNumber
{
    public static class Menu
    {
        public static void ViewMenu()
        {
            Console.WriteLine("Welcome to the Games!!");
            Console.WriteLine("Please select \n " +
                "1 - Guess the Number \n " +
                "2 - Rock Paper Scissors \n");
        }

        public static bool MenuSelection()
        {
            var inputSelection = Console.ReadLine();
            if (!int.TryParse(inputSelection, out int inputSelectedValue))
            {
                Console.WriteLine("Error!! - Please select either 1 or 2 from the Menu.");
            }

            switch (inputSelectedValue)
            {
                case 1: GuessNumberGame guessNumberGame = new GuessNumberGame();
                        guessNumberGame.Play();
                        break;

                case 2: RockPaperScissorsGame rockPaperScissorsGame = new RockPaperScissorsGame();
                        rockPaperScissorsGame.Play();
                        break;

                default:
                    break;
            }

            return true;
        }

        public static void Play()
        {
            bool playAgain = true;
            while (playAgain)
            {
                Menu.ViewMenu();
                Menu.MenuSelection();
                Console.Write("Would you like to play again (Y/N): ");
                var answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
        }
    }
}
