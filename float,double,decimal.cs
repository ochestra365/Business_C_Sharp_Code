using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class float_double_decimal
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            Console.WriteLine($"float : {sizeof(float)}, bytes\ndouble : {sizeof(double)} bytes/ndecimal : {sizeof(decimal)}");
            Console.WriteLine($"float : {float.MinValue}~{float.MaxValue}");
            Console.WriteLine($"double : {double.MinValue}~{double.MaxValue}");
            Console.WriteLine($"decimal : {decimal.MinValue}~{decimal.MaxValue}");

        }
    }
}
