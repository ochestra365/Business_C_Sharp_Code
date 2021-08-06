using System;
using System.Diagnostics;
using System.Text;
namespace GIT에_올릴_업무코드
{
    class String_StringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is StringBuilder Test.");
            Console.WriteLine($"{sb.ToString()},{sb.Length}");

            sb.Clear();
            sb.Append("This is a new string.");
            Console.WriteLine($"{sb.ToString()}({sb.Length} characters)");

            sb.Insert(5, "xyz", 2);
            Console.WriteLine($"{sb.ToString()}({sb.Length} characters)");

            sb.Remove(5, 4);
            Console.WriteLine($"{sb.ToString()}({sb.Length} characters)");

            Stopwatch time = new Stopwatch();
            string test = string.Empty;
          //  time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }
         //   time.Stop();
         //   Console.WriteLine("String : " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder();
         //   time.Reset();
          //  time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test1.Append(i);
            }
         //   time.Stop();
         //   Console.WriteLine("StringBuilder" + time.ElapsedMilliseconds + " ms");
        }
    }
}
