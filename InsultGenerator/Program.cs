using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Ask name
            string name = GetName();

            //Generate a random insult
            GenerateInsult(name, rnd);
        }
        private static string GetName()
        {
            Console.WriteLine("Welcome to the insult generator. What is your name?");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + " " + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }
        private static void Menu(string name, Random rnd)
        {
            Console.WriteLine("Would you like another insult? y/n");
            if (Console.ReadLine() == "y")

                GenerateInsult(name, rnd);
        }
        private static string GetAdjective(Random rnd)
        {
            string[] adjectives = { "a Transgender", "a Nigga-Fagot", "Crusty ass", "Transage", "Pedo" };
            return adjectives[rnd.Next(5)];
        }
        private static string GetCompoundAdjective(Random rnd)
        {
            string[] compoundAdjectives = { "Nigga-Faggot", "SJW", "Micro-Penised", "Lizard-Man", "Ricegum-Dickrider", "Dickrider", "Irelevent", "Communist"};
            return compoundAdjectives[rnd.Next(8)];
        }
        private static string GetObject(Random rnd)
        {
            string[] objects = { "Gnome", "Sheep", "Pig-Doggo", "Retard", "Attack-Helicopter", "Turtle", "Nigga-Fagot" };
            return objects[rnd.Next(7)];
        }
    }
}
