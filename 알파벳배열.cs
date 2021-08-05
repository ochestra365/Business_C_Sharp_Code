using System;

namespace GIT에_올릴_업무코드
{
    class 알파벳배열
    {
        static void Main(string[] args)
        {
            string[] name = { "Mouse", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);

            Array.Sort(name);
            PrintArray("After Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);
        }

        private static void PrintArray(string s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name) Console.WriteLine("{0} ", n);
            Console.WriteLine();
        }
    }
}
