using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Simpletron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***            Welcome to Simpletron!          ***");
            Console.WriteLine("*** Please enter your program one instruction  ***");
            Console.WriteLine("*** (or data word) at a time into the input    ***");
            Console.WriteLine("*** text field. I will display the location    ***");
            Console.WriteLine("*** number and a question mark (?). You        ***");
            Console.WriteLine("*** type the word for that location. Press the ***");
            Console.WriteLine("*** Done button to stop entering your program. ***");
            Console.WriteLine();

            int count = 0;
            int input;

            do
            {
                Simpletron.PrintOuput(count);
                input = int.Parse(Console.ReadLine());
                Simpletron.memory[count] = input;
                count++;

            } while (input != -99999);

            Console.WriteLine();
            Console.WriteLine("*** Program loading completed ***");
            Console.WriteLine("*** Program execution begins ***");
            Console.WriteLine();

            Simpletron.ExecuteProgram();

            count++;
            Console.ReadLine();
        }
    }
}
