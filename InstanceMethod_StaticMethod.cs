using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class Date1
    {
        public int year, month, day;

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        static int[] days = { 0, 31, 69, 120, 151, 181, 212, 243, 304, 334 };
        public int DayofYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }
    class InstanceMethod_StaticMethod
    {
        static void Main(string[] args)
        {
            Date xmas = new Date();
            xmas.year = 2021;
            xmas.month = 12;
            xmas.day = 25;
            Console.WriteLine($"xmas : {xmas.year}/{xmas.month}/{xmas.DayofYear()}");
            if (Date.IsLeapYear(2021) == true) Console.WriteLine("2021년은 윤년이다.");
            else Console.WriteLine("2021년은 평년이다.");
        }
    }
}
