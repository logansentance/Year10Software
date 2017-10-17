using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Door");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.WriteLine("Behind door 1 is Bo Browning");
            }
            else if (selection == "2")
            {
                Console.WriteLine("Behind door 2 is Bo and Txai having some fun");
            }
            else if (selection == "3")
            {
                Console.WriteLine("Behind door 3 is Bo and Txai having to much fun");
            }
            else if (selection == "4")
            {
                Console.WriteLine("Behind door 4 is Bo and Txai having Sex");
            }
            else
            {
                Console.WriteLine("Bo and Txai are busy please leave");
            }

            Console.ReadLine();


        }
    }
}
