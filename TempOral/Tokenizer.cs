using System;
using System.Collections.Generic;

namespace TempOralApp
{
    public class Tokenizer
    {
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

        public List<Token> Tokenize(string temporalCode)
        {
            List<Token> tokens = new List<Token>();
            int current = 0;

            while (current < temporalCode.Length)
            {
                char c = temporalCode[current];
                switch (c)
                {
                    case ' ':
                    case '\t':
                    case '\n':
                        // Ignore whitespace characters
                        break;
                    case '(':
                        tokens.Add(new Token(TokenType.LPAREN, "("));
                        break;
                    case ')':
                        tokens.Add(new Token(TokenType.RPAREN, ")"));
                        break;
                    case ';':
                        tokens.Add(new Token(TokenType.SEMICOLON, ";"));
                        break;
                    default:
                        if (char.IsDigit(c))
                        {
                            int start = current;
                            while (current < temporalCode.Length && char.IsDigit(temporalCode[current]))
                            {
                                current++;
                            }
                            string number = temporalCode.Substring(start, current - start);
                            tokens.Add(new Token(TokenType.NUMBER, number));
                            current--;
                        }
                        else if (char.IsLetter(c))
                        {
                            int start = current;
                            while (current < temporalCode.Length && (char.IsLetterOrDigit(temporalCode[current]) || temporalCode[current] == '_'))
                            {
                                current++;
                            }
                            string identifier = temporalCode.Substring(start, current - start);
                            TokenType type;
                            if (identifier == "print")
                            {
                                type = TokenType.PRINT;
                            }
                            else
                            {
                                type = TokenType.IDENTIFIER;
                            }
                            tokens.Add(new Token(type, identifier));
                            current--;
                        }
                        else if (c == '"')
                        {
                            int start = current + 1;
                            current++;
                            while (current < temporalCode.Length && temporalCode[current] != '"')
                            {
                                current++;
                            }
                            string str = temporalCode.Substring(start, current - start);
                            tokens.Add(new Token(TokenType.STRING, str));
                        }
                        else
                        {
                            throw new Exception($"Unexpected character: {c}");
                        }
                        break;
                }
                current++;
            }

            return tokens;
        }
    }
}
