using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while (repeat == true) ;
            {
                string result = "draw";
                Printscore(ref userScore, ref computerScore);             //Print Scores
                string userChoice = UserTurn();                           //User's Turn
                string computerChoice = ComputerTurn();                   //Computer's Turn
                result = DetermineWinner(userChoice, computerChoice);     //Determine Winner
                GiveFeedBack(result, userChoice, computerChoice);         //Provide Feedback
                updateScores(result, ref userScore, ref computerScore);   //Update Score
                repeat = PlayAgain();                                     //Ask To Play Again
            }
        }

        private static void Printscore(ref int userScore, ref int computerScore)
        {
            //Code for printing score
        }
        private static string UserTurn()
        {
            return "Rock";
        }
        private static string ComputerTurn()
        {
            return "Paper";
        }
        private static string DetermineWinner(string user, string computer)
        {
            return "User";
        }
        private static void GiveFeedBack(string result, string userChoice, string computerChoice)
        {
            Console.Clear();
            Console.WriteLine("User: " + userScore + "     Compter: " + computerScore);
        }
        private static bool PlayAgain()
        {
            return true;
        }
        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {

        }
    }
}
