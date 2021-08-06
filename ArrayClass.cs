using System;

namespace GIT에_올릴_업무코드
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 };

            int[] b;
            b = (int[])a.Clone();
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);
            PrintArray(c);

            a.CopyTo(c, 3);
            PrintArray(c);

            Array.Reverse(a);
            PrintArray(a);

            Array.Clear(a, 0, a.Length);
            PrintArray(a);
        }
        private static void PrintArray(int[] a)
        {
            foreach (var i in a)
            {
                Console.WriteLine("{0,5}", i);
                Console.WriteLine();
            }
        }
    }
}
