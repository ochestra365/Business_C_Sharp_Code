using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class dynamic형_일반화_프로그램
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 32, 47, 85, 46, 93, 47, 50, 71 };
            double[] d = { 0.1, 5.3, 6.7, 8.5, 4.9, 6.1 };
            float[] f = { 1.2f, 5.6f, 7.8f, 6.1f, 3.4f, 8.8f };
            decimal[] c = { 123, 783, 456, 234, 456, 748 };

            PrintArray<int>("a[] : ", a);
            CalcArray<int>(a);
            PrintArray<double>("d[] : ", d);
            CalcArray<double>(d);
            PrintArray<float>("f[] : ", f);
            CalcArray<float>(f);
            PrintArray<decimal>("c[] : ", c);
            CalcArray<double>(c);
        }

        private static void CalcArray<T>(T[] a)
        {
            throw new NotImplementedException();
        }

    private static void PrintArray<T>(string s, T[] a) where T : struct
    {
        Console.Write(s);
        foreach (var item in a) Console.Write($"{item}");
    }
}
}
