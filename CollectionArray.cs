using System;
using System.Collections;
namespace GeneralMethod
{
   
    class CollectionArray
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Random r = new Random();

            PrintValue(a);
            for (int i = 0; i < 10; i++) a.Add(r.Next(100));
            PrintValue(a);
            a.Sort();
            PrintValue(a);

            a.RemoveAt(3);
            PrintValue(a);
        }
        private static void PrintValue(ArrayList a)
        {
            Console.WriteLine("출력");
            Console.WriteLine("  Count = {0}", a.Count);
            Console.WriteLine($"  Capacity = {a.Capacity}");
            foreach (var i in a) Console.Write($"{i}");
            Console.WriteLine();
        }
    }
}
}
