using System;
using System.Diagnostics;
using System.Text;
using System.Collections;
namespace GIT에_올릴_업무코드
{
    public class ReverseComparer : IComparer //인터페이스로 내림차순 구현
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }

    }
    class ArrayDescending
    {
        static void Main(string[] args)
        {
            string[] animalEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse", "horse", "derr" };
            string[] animalKo = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };
            Display("초기배열", animalEn);
            Array.Sort(animalEn);
            Array.Reverse(animalEn);
            Display("Sort->Reverse", animalEn);

            Display("초기 배열", animalKo);
            Array.Sort(animalKo, 2, 3);
            Display("[2]에서 3개 정렬 후 ", animalKo);

            IComparer revComparer = new ReverseComparer();

            Array.Sort(animalKo, revComparer);
            Display("내림차순 정렬", animalKo);
        }
        private static void Display(string comment, string[] arr)
        {
            Console.WriteLine(comment);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)//배열의 하한에서 상한까지 출력
            {
                Console.WriteLine($"   {arr[i]}");
            }
            Console.WriteLine();
        }
    }
}
