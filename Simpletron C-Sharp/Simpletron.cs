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

        private static int instructionRegister = 0;
        private static int accumulator = 0;
        private static int instructionCounter = 0;
        private static int operationCode = 0;
        private static int operand = 0;

        public static int[] memory;
        public Simpletron() 
        {
            memory = new int[100];
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

        public static void ExecuteProgram()
        {
            while(instructionCounter < memory.Length)
            {
                instructionRegister = memory[instructionCounter];

                Parse(instructionRegister);
                if (instructionRegister == 4300)
                    break;

                instructionCounter++;
            }
        }

        private static void Parse(int instructionRegister)
        {
            operationCode = instructionRegister / 100;
            operand = instructionRegister % 100;

            switch (operationCode)
            {
                case READ:
                    Console.Write("Enter an Integer: ");
                    memory[operand] = int.Parse(Console.ReadLine());
                    break;
                case WRITE:
                    Console.WriteLine(memory[operand]);
                    Console.WriteLine();
                    break;
                case LOAD:
                    accumulator += memory[operand];
                    break;
                case STORE:
                    memory[operand] = accumulator;
                    break;
                case ADD:
                    accumulator += memory[operand];
                    break;
                case SUBSTRACT:
                    accumulator -= memory[operand];
                    break;
                case DIVIDE:
                    accumulator /= memory[operand];
                    break;
                case MULTIPLY:
                    accumulator *= memory[operand];
                    break;
                case HALT:
                    Console.WriteLine("*** Simpletron execution terminated ***");
                    break;
            }
        }
    }
}
