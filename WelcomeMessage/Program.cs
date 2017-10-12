using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write your age: ");
            string age = Console.ReadLine();
            Console.Write("Write you name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Im {name} and this is my Pawn shop");
            Console.WriteLine($"What is your {Age} ");



            //Wait till the end
            Console.ReadLine();
        }
    }
}
