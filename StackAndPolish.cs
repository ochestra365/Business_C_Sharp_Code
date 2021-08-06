using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class StackAndPolish
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            foreach (var i in token) Console.WriteLine($"{i}");
            Console.Write(" = ");

            Stack<double> nStack = new Stack<double>();
            foreach(var s in token)
            {
                if (isOperator(s))
                {
                    switch (s) 
                    {
                        case "+":
                            nStack.Push(nStack.Pop() + nStack.Pop());break;
                        case "-":
                            nStack.Push(nStack.Pop() - nStack.Pop());break;
                        case "*":
                            nStack.Push(nStack.Pop() * nStack.Pop());break;
                        case "/":
                            nStack.Push(nStack.Pop() / nStack.Pop());break;
                    }
                }
                else
                {
                    nStack.Push(double.Parse(s));
                }
                Console.WriteLine(nStack.Pop());
            }
        }

        private static bool isOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/") return true;
            else return false;
        }
    }
}
