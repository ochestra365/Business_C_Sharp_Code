using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> s1 = new SortedDictionary<int, string>();
            s1.Add(3, "Three");
            s1.Add(4, "Four");
            s1.Add(1, "One");
            s1.Add(2, "Two");

            SortedDictionary<string, int> s2 = new SortedDictionary<string, int>();
            s2.Add("one", 1);
            s2.Add("two", 2);
            s2.Add("three", 3);
            s2.Add("four", 4);
            Console.WriteLine(s2["two"]);
            foreach (var kvp in s2) Console.Write("{0,-10}", kvp);
            Console.WriteLine();

            int val;
            if (s2.TryGetValue("ten", out val)) Console.WriteLine("key : ten, value : {0}", val);//ten이라는 key의 value값을 보낸다.
            else Console.WriteLine("키가 유효하지 않음");

            if (s2.TryGetValue("one", out val)) Console.WriteLine("key : one, value : {0}", val);

            Console.WriteLine(s2.ContainsKey("one"));
            Console.WriteLine(s2.ContainsKey("ten"));
            Console.WriteLine(s2.ContainsKey("2"));
            Console.WriteLine(s2.ContainsKey("6"));
            s2.Remove("one");
            foreach (KeyValuePair<string, int> kvp in s2) Console.Write("{0,-10}", kvp);
            Console.WriteLine();
        }
    }
}
