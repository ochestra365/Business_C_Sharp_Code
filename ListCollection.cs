using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class ListCollection
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            PrintValue(a);
            for (int i = 0; i < 10; i++) a.Add(r.Next(100));
            PrintValue(a);
            a.Sort();
            PrintValue(a);
        }

        private static void PrintValue(List<int> a)
        {
            Console.WriteLine("출력");
            Console.WriteLine($"  Count={a.Count}");
            Console.WriteLine($"  Capacity = {a.Capacity}");//들어간 숫자
            foreach (var i in a) Console.Write($"{i}");
            Console.WriteLine();
        }
    }
}
