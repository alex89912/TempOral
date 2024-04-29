using System;
using System.Collections.Generic;

namespace TempOralApp
{
    public class Interpreter
    {
        // Interpret method to execute TempOral code
        public void Interpret(string temporalCode)
        {
            Lexer lexer = new Lexer();
            List<Lexer.Token> tokens = lexer.Tokenize(temporalCode);

            // Placeholder implementation for interpreting TempOral code
            //foreach (var token in tokens)
            //{
            //    //Console.WriteLine($"Token Type: {token.Type}, Value: {token.Value}");
            //}
            
            // Implement logic to execute the TempOral code based on the tokens
            ExecuteTokens(tokens);
        }

        private void ExecuteTokens(List<Lexer.Token> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];

                switch (token.Type)
                {
                    case Lexer.TokenType.PRINT:
                        // Execute the PRINT statement
                        if (i + 1 < tokens.Count && tokens[i + 1].Type == Lexer.TokenType.STRING)
                        {
                            string stringValue = tokens[i + 1].Value;
                            // Remove double quotes from the string value
                            stringValue = stringValue.Trim('"');
                            Console.WriteLine(stringValue);
                        }
                        else
                        {
                            Console.WriteLine("Error: Missing string token after PRINT");
                        }
                        break;
                    case Lexer.TokenType.STRING:
                        // Skip string tokens here, as they're processed by PRINT
                        break;
                    case Lexer.TokenType.LPAREN:
                    case Lexer.TokenType.RPAREN:
                    case Lexer.TokenType.SEMICOLON:
                        // Skip parentheses and semicolon tokens
                        break;
                    default:
                        // Skip unsupported token types
                        Console.WriteLine(
                            $"Error: Unsupported token type '{token.Type}', Value: {token.Value}"
                        );
                        break;
                }
            }
        }
    }
}
