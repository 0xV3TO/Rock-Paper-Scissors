using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Utils
    {
        public static string getPlayerInput()
        {
            // prompting to the user to get a choice.
            Console.Write("enter your choice (rock,paper or scissors): ");
            try
            {
                string choice = (Console.ReadLine()).ToLower();
                return choice;
            } catch (Exception e)
            {
                Exit(e.Message);
                return "";
            }
            
        }
        public static void Exit(string cause)
        {
            Console.Clear();
            Console.WriteLine("Exiting... {0}", cause);
            Environment.Exit(0);
        }
        public static void ShowChoices(string player, string computer, int playerScore, int computerScore)
        {
            Console.WriteLine("\nYou chosen: {0}", player);
            Console.WriteLine("Computer chosen: {0}", computer);

            Console.Write("you {0} - {1} computer.", playerScore, computerScore);
        }
        public static void YouWin()
        {
            Console.WriteLine("You Win!");
            PlayAgain();
        }
        public static void YouLose()
        {
            Console.WriteLine("You Lose!");
            PlayAgain();
        }
        public static void PlayAgain()
        {
            Console.Write("Do you want to play again? (yes/no): ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.Clear();
                Program.Game();
            } else
            {
                Exit("Goodbye!");
            }
        }
    }
}
