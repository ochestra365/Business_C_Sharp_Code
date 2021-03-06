using System;

namespace GIT에_올릴_업무코드
{
    class Delegate기본_배열에서_홀수짝수찾기
    {
        public static bool IsEven(int n) { return n % 2 == 0; }
        public static bool IsOdd(int n) { return n % 2 != 0; }

        delegate bool MemberTest(int a);
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 8, 54, 23, 4, 6, 4 };
            Console.WriteLine("짝수의 개수: " + Count(arr, IsEven));
            Console.WriteLine("홀수의 개수: " + Count(arr, IsOdd));
        }

        static string Count(int[] a, MemberTest testMethod)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if (testMethod(n) == true) cnt++;
            }
            //return (string)cnt;
        }
    }
}
