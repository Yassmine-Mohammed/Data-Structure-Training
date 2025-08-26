using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace datastructurebasics
{
    public class Program
    {
        static bool arepair(char open, char close)
        {
            if (open == '(' && close == ')') { return true; }
            else if (open == '{' && close == '}') { return true; }
            else if (open == '[' && close == ']') { return true; }
            return false;
        }
        static bool arebalanced(string exp)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                {
                    s.Push(exp[i]);
                }
                else if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                {
                    if (s.Count == 0||!arepair(s.Peek(), exp[i]))
                    {
                        return false;
                    }
                    else
                    {
                        s.Pop();
                    }
                }
            }
        
    
            return (s.Count == 0 );
        }
        static void Main(string[] args)
        {
            Console.Write("enter you experation: ");
            string exp = Console.ReadLine();
            if (arebalanced(exp))
            {
                Console.WriteLine("The expression is balanced");
            }
            else
            {
                Console.WriteLine("The expression is not balanced");
            }
        }
    }
}
