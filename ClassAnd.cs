using System;
using System.Collections.Generic;
using System.Linq;
namespace GIT에_올릴_업무코드
{
    struct DateStruct { public int year, month, day; }
    class DateClass { public int year, month, day; }
   
    class ClassAnd
    {
        static List<Student> students;
        static void Main(string[] args)
        {
            DateStruct sDay;
            sDay.year = 2021;
            sDay.month = 8;
            sDay.day = 4;
            Console.WriteLine($"Sday: {sDay.year}/{sDay.month}/{sDay.day}");

            DateClass cDay = new DateClass();
            cDay.year = 2021;
            cDay.month = 8;
            cDay.day = 22;
            Console.WriteLine($"cDay : {cDay.year}/{cDay.month}/{cDay.day}");

            DateStruct sDay2 = new DateStruct();
            Console.WriteLine($"sDay2: {sDay2.year}/{sDay2.month}/{sDay2.day}");
            DateClass cDay2 = new DateClass();
            Console.WriteLine($"cDay2: {cDay2.year}/{cDay2.month}/{cDay2.day}");

            DateStruct s = sDay;
            DateClass c = cDay;
            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("s : {0}/{1}/{2}", s.year, s.month, s.day);
            Console.WriteLine("c : {0}/{1}/{2}", c.year, c.month, c.day);
            Console.WriteLine($"sDay : {sDay.year}/{sDay.month}/{sDay.day}");
            Console.WriteLine($"cDay : {cDay.year}/{cDay.month}/{cDay.day}");
        }
    }
}

