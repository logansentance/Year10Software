using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please enter you birth date:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            //calculation
            int age = DateTime.Today.Year - birthday.Year;

            //selection
            if (age == 16)
            {
                Console.WriteLine("");
            }
            if (age >= 0 && age < 13)
            {
                Console.WriteLine("Bo and Txai having sex");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a SJW");
            }
            else if(age >= 18)
            {
                Console.WriteLine("Special forces");
            }
            else
            {
                Console.WriteLine("Coen is gay");
            }

            //wait
            Console.ReadLine();
        }
    }
}
