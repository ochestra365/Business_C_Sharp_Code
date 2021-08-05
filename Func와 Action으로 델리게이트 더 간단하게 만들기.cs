using System;

namespace GIT에_올릴_업무코드
{
    class Func와_Action으로_델리게이트_더_간단하게_만들기
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 3, 675, 8, 23 };
            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine("짝수의 개수: " + n);
            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine("홀수의 개수: " + n);
        }

        private static int Count(int[] arr, Func<int, bool> testMethod)
        {
            int cnt = 0;
            foreach (var n in arr)
            {
                if (testMethod(n)) cnt++;
            }
            return cnt;
        }
    }
}
