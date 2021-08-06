using System;
using System.Diagnostics;
using System.Text;
namespace GIT에_올릴_업무코드
{
    class TimeSpanCalendar
    {
        static void Main(string[] args)
        {
            Console.Write("생년월일 시분초 입력: ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Now;

            TimeSpan interval = date2 - date1;
            Console.WriteLine($"탄생시간 : {date1}");
            Console.WriteLine($"현재시간 : {date2}");
            Console.WriteLine($"생존시간 : {interval.ToString()}");
            Console.WriteLine($"{interval.Days}일 {interval.Hours}시간 {interval.Minutes}분 {interval.Seconds}초 생존");
        }
    }
}
