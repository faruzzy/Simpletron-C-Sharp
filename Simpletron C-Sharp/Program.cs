using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpletron
{
    class Program
    {
        // Main entry point
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Simpletron! ***");
            Console.WriteLine("*** Please enter your program one instruction ***");
            Console.WriteLine("*** (or data word) at a time into the input ***");
            Console.WriteLine("*** text field. I will display the location ***");
            Console.WriteLine("*** number and a question mark (?). You ***");
            Console.WriteLine("*** type the word for that location. Press the ***");
            Console.WriteLine("*** Done button to stop entering your program. ***");

            int count = 0;
            string input;
            do
            {
                Simpletron.PrintOuput(count);
                input = Console.ReadLine();

                Simpletron.Parse(input);
                count++;

            } while (input != "-99999");

            Console.WriteLine("*** Program loading completed ***");
            Console.WriteLine("*** Program execution begins ***");

            Console.ReadLine();
        }
    }
}
