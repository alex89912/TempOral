using System;
using System.IO;
using TempOralApp;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0 && args[0].Equals("-f", StringComparison.OrdinalIgnoreCase))
        {
            if (args.Length > 1)
            {
                RunTempoFile(args[1]);
            }
            else
            {
                Console.WriteLine("Please provide a file name after the '-f' option.");
            }
        }
        else
        {
            RunShell();
        }
    }

    static void RunShell()
    {
        Console.WriteLine("TempOral Shell");
        Console.WriteLine("Enter 'exit' to quit.");
        Console.WriteLine("Enter 'run <file_name>' to execute a TempOral file.");

        while (true)
        {
            Console.Write(">>> ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
            else if (input.ToLower().StartsWith("run "))
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    RunTempoFile(parts[1]);
                }
                else
                {
                    Console.WriteLine("Invalid run statement. Format: run <file_name>");
                }
            }
            else
            {
                RunTempoCode(input);
            }
        }
    }

    static void RunTempoFile(string filePath)
    {
        if (File.Exists(filePath) && Path.GetExtension(filePath).Equals(".tempo", StringComparison.OrdinalIgnoreCase))
        {
            // Read the contents of the .tempo file and execute it
            string temporalCode = File.ReadAllText(filePath);
            // Tokenize, parse, and interpret TempOral code
            Interpreter interpreter = new Interpreter();
            interpreter.Interpret(temporalCode);
        }
        else
        {
            Console.WriteLine("File not found or not a .tempo file.");
        }
    }

    static void RunTempoCode(string code)
    {
        // Tokenize, parse, and interpret TempOral code
        Interpreter interpreter = new Interpreter();
        interpreter.Interpret(code);
    }
}
