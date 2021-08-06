using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class SearchString
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2="Cow";
            bool b = s1.Contains(s2);
            Console.WriteLine($"{s2} is in the string {s1} : {b}");

            if (b)
            {
                int index = s1.IndexOf(s2);//배열의 인덱스
                if (index >= 0) Console.WriteLine($"{s2} begins at index {index}");
            }
            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)//배열에 존재하느냐-->문자열 비교 인터페이스에서 현재 대소문자를 무시함.
            {
                Console.WriteLine($"{s2} is in the string {s1}");
            }
        }
    }
}
