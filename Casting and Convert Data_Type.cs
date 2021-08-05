using System;

namespace GIT에_올릴_업무코드
{
    class Casting_and_Convert_Data_Type
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;
            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
