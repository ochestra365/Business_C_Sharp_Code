using System;
using System.Diagnostics;
using System.Text;
namespace GIT에_올릴_업무코드
{
    class ThreeWaytoSendParam
    {
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine(a);

            int b = 3;
            Sqr(ref b);
            Console.WriteLine(b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine($"{name}, {id}");
        }
        private static void GetName(out string name, out int id)
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            id = int.Parse(Console.ReadLine());
        }

        static void Sqr(int a)
        {
            a = a * a;
        }
        static void Sqr(ref int a)
        {
            a = a * a;
        }
    }
}
