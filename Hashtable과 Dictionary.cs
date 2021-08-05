using System;
using System.Collections.Generic;
using System.Text;

namespace GIT에_올릴_업무코드
{
    class Hashtable과_Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();
            colorTable.Add("Red", "빨간색");
            colorTable.Add("Green", "초록색");
            colorTable.Add("Blue", "파란색");

            foreach (var v in colorTable) Console.WriteLine($"colorTable[{v.Key}]={v.Value}");

            try
            {
                colorTable.Add("Red", "빨간색");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine($"Yellow =>{colorTable["Yellow"]}");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n" + colorTable["Red"]);
            Console.WriteLine(colorTable["Green"]);
            Console.WriteLine(colorTable["Blue"]);
        }
    }
}
