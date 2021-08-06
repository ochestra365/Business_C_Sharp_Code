using System;
using System.Linq;
using System.Collections;
namespace GIT에_올릴_업무코드
{
    class UsingRamda
    {
        delegate double CalcMethod(double a, double b);
        delegate bool IsTeenAger(Student student);
        delegate bool IsAdult(Student student);
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Action line = () => Console.WriteLine();
            line();

            CalcMethod add = (a, b) => a + b;
            CalcMethod substract = (a, b) => a - b;

            Console.WriteLine(add(10, 20));
            Console.WriteLine(substract(10.5, 20));

           // IsTeenAger isTeen = delegate (Student s) { return s.Age}
        }
    }
}
