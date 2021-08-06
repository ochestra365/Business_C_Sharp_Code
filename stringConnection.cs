using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class stringConnection
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello" + userName + ".Todya is" + date + ".";
            Console.WriteLine("strPlus");

            string strFormat = String.Format("Hello {0}. Today is {1}.", date, userName);
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);
            string strConcat = String.Concat("Hello", userName, ".Today is ", date);
            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon", };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}
