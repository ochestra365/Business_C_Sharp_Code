using System;
namespace GIT에_올릴_업무코드
{
    class OverflowException
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int.Maxvalue = {int.MaxValue}");
            int x = int.MaxValue, y = 0;

            checked//오버플로 예외
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"int.MaxValue + 10 = {y}");
        }
    }
}
