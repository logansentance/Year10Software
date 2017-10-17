using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberfun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            Console.WriteLine("Pleasse enter a number for X:");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for Y:");
            float Y = float.Parse(Console.ReadLine());


            //Output
            Console.WriteLine("X plus Y = " + (X + Y));
            Console.WriteLine("X minus Y = " + (X - Y));
            Console.WriteLine("X times Y = " + (X * Y));
            Console.WriteLine("X divided Y = " + (X / Y));

            //Wait
            Console.ReadKey();
        }
    }
}
