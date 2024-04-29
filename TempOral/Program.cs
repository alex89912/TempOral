using System;
using System.Collections.Generic;
using System.Text;

namespace TempOralApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TempOral Shell");
            Console.WriteLine("Enter 'exit' to quit.");
            Console.WriteLine();

            Interpreter interpreter = new Interpreter();
            StringBuilder temporalCodeBuilder = new StringBuilder();
            while (true)
            {
                Console.Write(">>> ");
                string line = Console.ReadLine();

                if (line == "exit")
                    break;

                temporalCodeBuilder.AppendLine(line);
                interpreter.Interpret(temporalCodeBuilder.ToString());
            }
        }
    }
}
