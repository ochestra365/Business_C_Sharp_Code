using System;
namespace GIT에_올릴_업무코드
{
    class PredicateDelegate
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));
            Predicate<string> isLoerCse = s => s.Equals(s.ToLower());
            Console.WriteLine(isLoerCse("This is test"));
        }
    }
}
