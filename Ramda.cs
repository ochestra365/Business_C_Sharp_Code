using System;
using System.Collections;
namespace GIT에_올릴_업무코드
{
    class Ramda
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            int n = Count(arr, x => (double)x % 2 == 0);
            Console.WriteLine("홀수의 개수" + n);

            n = Count(arr, x => (double)x % 2 == 1);
        }
        private static int Count(int[] arr, Func<object, bool> testMethod)
        {
            int cnt = 0;
            foreach (var n in arr) if (testMethod(n)) cnt++;
            return cnt;
        }
    }
}
