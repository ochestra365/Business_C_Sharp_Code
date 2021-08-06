using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class Stopwatch
    {
        static int[] f = new int[50];
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("n을 입력하세요: ");
                int n = int.Parse(Console.ReadLine());
                var watch = System.Diagnostics.Stopwatch.StartNew();
                f[1] = f[2] = 1;
                for (int i = 3; i <= n; i++) f[i] = f[i - 1] + f[i - 2];
                for (int i = 1; i <= n; i++) Console.WriteLine($"{f[i]}");
                Console.WriteLine();
                watch.Stop();
                var elapseMs = watch.ElapsedMilliseconds;
                Console.WriteLine($"실행 시간은 {elapseMs}ms\n");
                watch = System.Diagnostics.Stopwatch.StartNew();
                for (int i = 1; i <= n; i++) Console.WriteLine($"{FiboRecursive(i)}");
                Console.WriteLine();
                watch.Stop();
                elapseMs = watch.ElapsedMilliseconds;
                Console.WriteLine($"실행시간은 {elapseMs}");
            }
        }

        private static int FiboRecursive(int n)
        {

            if (n == 1 || n == 2) return 1;
            else return 2;
            //else return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }
    }
}
