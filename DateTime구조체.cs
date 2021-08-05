using System;

namespace GIT에_올릴_업무코드
{
    class DateTime구조체
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(1992, 7, 4, 8, 44, 0);
            DateTime date2 = new DateTime(1990, 1, 27, 12, 6, 0);

            Console.WriteLine(date1);
            Console.WriteLine(date2);

            Console.WriteLine($"{date1.ToString("yyyy년 M d일")}과 {date2.ToString("yyyy년 M월 d일")}의 차이는 {date1.Subtract(date2).Days}일입니다.");
            Console.WriteLine("\n오늘 : {0}", DateTime.Today);

            DateTime y = DateTime.Today.AddDays(-1);
            Console.WriteLine("어제 : {0}", y.ToShortDateString());

            DateTime t = DateTime.Today.AddDays(1);
            Console.WriteLine($"내일 : {t.ToShortDateString()}");

            Console.WriteLine("\n2021년은 {0}입니다.", DateTime.IsLeapYear(2021) ? "윤년" : "평년");
            Console.WriteLine("2021년 2월은 {0}입니다.\n", DateTime.DaysInMonth(2021, 2));

            string date = "1990-1-27 12:6";
            DateTime aDay = DateTime.Parse(date);
            Console.WriteLine(aDay);

            string input = "1992/7/4 8:44";
            DateTime bDay;
            if (DateTime.TryParse(input, out bDay))
            {
                Console.WriteLine();
            }
            Console.WriteLine();

            DateTime d1 = DateTime.Now;//로컬타임
            DateTime d2 = DateTime.UtcNow;//그리니치 표준시

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
