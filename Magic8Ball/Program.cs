using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        private static void PlayGame()
        {
            //Define array answers
            string[] answers = { "Maybe", "Yes", "No", "You gay nibba", "My wigga", "Ask again", "Ha Gay", "And i said NO NO NO NO NO NO", "And he said YES YES YES YES YES YES" };

            //Promt user
            Console.WriteLine("Ask me a question that can be answered 'yes' or 'no'. Type 'exit' to leave");

            //Only play game if user dosent type 'exit'
            if(Console.ReadLine() != "exit")
            {
                //Pick a random answer
                Random rnd = new Random();

                //Print out random item from array
                Console.WriteLine(answers[rnd.Next(9)]);

                //Blank line
                Console.WriteLine("");

                //Go again
                PlayGame();
            }

        }
    }
}
