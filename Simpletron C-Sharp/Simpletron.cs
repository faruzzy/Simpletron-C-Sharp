using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpletron
{
    public class Simpletron
    {
        // input/output operations
        const int READ = 10;
        const int WRITE = 11;

        // Load/store operations
        const int LOAD = 20;
        const int STORE = 21;

        // Arithmetic operations
        const int ADD = 30;
        const int SUBSTRACT = 31;
        const int DIVIDE = 32;
        const int MULTIPLY = 33;

        // Transfer of control Operations;
        const int BRANCH = 40;
        const int BRANCHNEG = 41;
        const int BRANCHZERO = 42;
        const int HALT = 43;

        private static int accumulator = 0;
        private static String[] memory;

        public Simpletron()
        {
            memory = new String[100];
        }


        public static void PrintOuput(int n)
        {
            int x = n / 10;
            Console.Write("{0}{1} ? ", x, n);
        }

        private int getMemoryLocation(string location)
        {
            if (location[0].Equals('0'))
                return int.Parse(location[1].ToString());
            else
                return int.Parse(location);
        }

        public static void Parse(string s)
        {
            int operation = int.Parse(s.Substring(1, 2));
            int location = int.Parse(s.Substring(3, 4));

            switch (operation)
            {
                case READ:
                    memory[location] = Console.ReadLine();
                    break;
                case WRITE:
                    Console.WriteLine(memory[location]);
                    break;
                case LOAD:
                    accumulator += int.Parse(memory[location]);
                    break;
                case STORE:
                    memory[location] = accumulator + "";
                    break;
                case ADD:
                    accumulator += int.Parse(memory[location]);
                    break;
                case SUBSTRACT:
                    accumulator -= int.Parse(memory[location]);
                    break;
                case DIVIDE:
                    accumulator /= int.Parse(memory[location]);
                    break;
                case MULTIPLY:
                    accumulator *= int.Parse(memory[location]);
                    break;
            }
        }
    }
}
