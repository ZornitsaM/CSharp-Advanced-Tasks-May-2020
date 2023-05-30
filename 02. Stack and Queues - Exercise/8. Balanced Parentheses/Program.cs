using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string expressions = Console.ReadLine();
            var stack = new Stack<char>();
            
            foreach (var c in expressions)
            {
                if (c=='('|| c=='['|| c=='{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Any())
                    {
                        char current = stack.Peek();

                        if (current == '(' && c == ')')
                        {
                            stack.Pop();
                        }

                        else if (current == '{' && c == '}')
                        {
                            stack.Pop();
                        }
                        else if (current == '[' && c == ']')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }

            if (stack.Count==0)
            {
                Console.WriteLine("YES");
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
