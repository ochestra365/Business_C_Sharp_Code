using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class StringAndConvert
    {
        static void Main(string[] args)
        {
            string input;
            int value;
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);
            if (!result) Console.WriteLine($"{input}치환불가");
            else Console.WriteLine($"int{value}");

            Console.WriteLine("2. double로 변환할 문자열");
            input = Console.ReadLine();
            try
            {
                double m = Double.Parse(input);
                Console.WriteLine($"double : {m}\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
