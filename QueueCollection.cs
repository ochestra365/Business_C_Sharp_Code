using System;
using System.Collections.Generic;
namespace GIT에_올릴_업무코드
{
    class QueueCollection
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Rabbit");
            PrintQueue("que : ", que);

            Console.WriteLine($"Deque : {que.Dequeue()}");
            Console.WriteLine($"Peek : {que.Peek()}");

            Queue<string> que2 = new Queue<string>(que.ToArray());//que2에 que복사
            PrintQueue("que2 : ", que2);

            string[] array = new string[que.Count];
            que.CopyTo(array, 0);//복사
            Queue<string> que3 = new Queue<string>(array);
            PrintQueue("que3 : ", que3);

            Console.WriteLine("que.Contains(Lion)={0}", que.Contains("Lion"));
        }

        private static void PrintQueue(string s, Queue<string> q)
        {
            Console.WriteLine("{0,-8}", s);
            foreach (var item in q) Console.Write("{0,-8}", item);
            Console.WriteLine();
        }
    }
}
