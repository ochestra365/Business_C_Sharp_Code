using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class GropSeparator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("표시할 숫자 입력(종료 -1)");
                string s = Console.ReadLine();
                double v = double.Parse(s);
                if (v == -1) break;
                Console.WriteLine(NumberwithGroupSeparater(s));
            }

        }
        private static string NumberwithGroupSeparater(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
            {
                s = string.Format("{0:N0}", v);
            }
            return s;
        }
    }
}
