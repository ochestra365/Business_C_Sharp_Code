using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class CalcLifeCycle
    {
        static void Main(string[] args)
        {
            Console.Write("생일을 입력하세요(yyyy/mm/dd): ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split('/');

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;

            int totalDays = 0;

            totalDays += DayOfYear(tYear, tMonth, tDay);

            int yearDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearDays - DayOfYear(bYear, bMonth, bDay);

            for (int year = bYear + 1; year < tYear; year++)
            {
                if (IsLeapYear(year)) totalDays += 366;
                else totalDays += 365;
            }
            Console.WriteLine($"{totalDays}");
        }

        private static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        private static int DayOfYear(int year, int month, int day)
        {
            return 0;
            //return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }
}
