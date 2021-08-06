using System;
using System.Collections;
namespace GIT에_올릴_업무코드
{
    class SortDuel
    {
        public class ReverseComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                string s1 = (string)x;
                string s2 = (string)y;
                return string.Compare(s2, s1);
            }
        }

        static void Main(string[] args)
        {
            string[] animalEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse" };
            string[] animalKo = { "개", "소", "토끼", "염소", "양", "쥐" };
            Display("Before Sort", animalEn, animalKo);
            Array.Sort(animalEn, animalKo);
            Display("After Sort", animalEn, animalKo);
            Array.Sort(animalKo, animalEn);
            Display("After Sort by Korea", animalEn, animalKo);

            IComparer revCom = new ReverseComparer();
            Array.Sort(animalEn, animalKo, revCom);
            Display("After Descending Sort", animalEn, animalKo);
        }
        private static void Display(string cmt, string[] a1, string[] a2)
        {
            Console.WriteLine(cmt);
            for (int i = 0; i < a1.Length; i++) { Console.WriteLine("[{0}]: {1,-8} {2,-8}", i, a1[i], a2[i]); }
            Console.WriteLine();
        }
    }
}
