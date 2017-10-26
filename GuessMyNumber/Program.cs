using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate random number from 1 to 100
            Random rnd = new System.Random();
            int randomNumber = rnd.Next(1, 101);

            // Set guess to number out of random range
            int guess = -1;

            // start loop
            while (guess != randomNumber)
            {
                // input
                guess = int.Parse(Console.ReadLine());

                // selection
                if (guess > randomNumber)
                {
                    Console.WriteLine("To High");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("To Low");
                }
                else
                {
                    Console.WriteLine("You got it");
                }
                
            }
            //Wait
            Console.ReadKey();
        }
    }
}
