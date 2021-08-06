using System;
using System.Diagnostics;
using System.Text;
namespace GIT에_올릴_업무코드
{
    class FindBigNum
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            FindBigNum x = new FindBigNum();
            Console.WriteLine("{0}", x.Larger(x.Larger(a, b), c));
        }
        private int Larger(int a, int c)
        {
            return (a >= c) ? a : c;
        }
    }
}
}
