using System;
using System.Collections.Generic;

namespace TempOralApp
{
    public class Lexer
    {
        // Define token types
        public enum TokenType
        {
            PRINT,
            ASSIGN,
            STRING,
            NUMBER,
            LPAREN,
            RPAREN,
            SEMICOLON,
            IDENTIFIER,
            // Add other token types as needed
        }

        // Token class representing individual tokens
        public class Token
        {
            public TokenType Type { get; }
            public string Value { get; }

            public Token(TokenType type, string value)
            {
                Type = type;
                Value = value;
            }
        }

        // Lexer function to tokenize TempOral code
        public List<Token> Tokenize(string input)
        {
            List<Token> tokens = new List<Token>();
            string[] separators = { "(", ")", ";" };

            // Split the input string based on separators
            string[] parts = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Process each part to generate tokens
            foreach (string part in parts)
            {
                string trimmedPart = part.Trim();
                if (!string.IsNullOrEmpty(trimmedPart))
                {
                    if (trimmedPart == "print")
                    {
                        tokens.Add(new Token(TokenType.PRINT, "print"));
                    }
                    else
                    {
                        tokens.Add(new Token(TokenType.STRING, trimmedPart));
                    }
                }
            }

            // Add tokens for parentheses and semicolon
            tokens.Add(new Token(TokenType.LPAREN, "("));
            tokens.Add(new Token(TokenType.RPAREN, ")"));
            tokens.Add(new Token(TokenType.SEMICOLON, ";"));

            return tokens;
        }
    }
}
