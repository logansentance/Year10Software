using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // wait
            Console.WriteLine("Please enter to start");
            Console.ReadLine();

            for(int i = 1; i <= 69; i++)
            {
                Console.WriteLine(i);
            }

            //While loop
            int j = 1;
            while(j <= 69)
            {
                Console.WriteLine("j");
                j++;
            }


            // wait
            Console.ReadKey();
        }
    }
}
