using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class Date
    {
        private int year, month, day;

        public Date()
        {
            year = 1;
            month = 1;
            day = 1;
        }
        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public void Printdate()
        {
            Console.WriteLine($"{year},{month},{day}");
        }
    }
    class CreateMethod
    {
        static void Main(string[] args)
        {
            Date birthDay = new Date(2000, 11, 22);
            Date christmas = new Date(2018, 12, 25);
            Date firstDay = new Date();

            birthDay.Printdate();
            christmas.Printdate();
            firstDay.Printdate();
        }

    
}
}
