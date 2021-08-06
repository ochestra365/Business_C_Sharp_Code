using System;
using System.Collections.Generic;
using System.Linq;
namespace GIT에_올릴_업무코드
{
    class LINQLISTARRAY
    {
        static void Main(string[] args)
        {
            List<int> lstData = new List<int> { 123, 456, 132, 96, 13, 465, 321 };
            Print("Data : ", lstData);
            List<int> lstOdd = new List<int>();
            lstOdd = SelectOddAndSort(lstData);
            int[] arrEven;
            //arrEven = SelectOddAndSort(lstData);

        }

        private static List<int> SelectOddAndSort(List<int> lstData)
        {
            throw new NotImplementedException();
        }

        /* private static List<int> SelectOddAndSort(List<int> lstData)
        {
            throw 
            return (from item in lstData
                    where item % 2 == 0
                    orderby item
                    select item).ToArray<int>();
        }
        */
        private static void Print(string s, IEnumerable<int>data)
        {
            Console.WriteLine(s);
            foreach (var i in data) Console.Write(" " + i);
            Console.WriteLine();
        }
    }
}
