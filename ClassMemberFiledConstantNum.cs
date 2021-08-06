using System;

namespace GIT에_올릴_업무코드
{
    class Product
    {
        public string name;
        public int price;
    }
    class MyMath
    {
        public static double PI = 3.14;
    }
    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }
    class MemberVariables
    {
        Product v = new Product();

    }
    class ClassMemberFiledConstantNum
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArray(v);
            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                    }
                    PrintArray(v);
                }
            }
        }

        private static void PrintArray(int[] v)
        {
            foreach (var i in v) Console.WriteLine("{0,5}", i);
            Console.WriteLine();
        }
    }
}
