using System;
namespace GIT에_올릴_업무코드
{
    class Mycollection<T>
    {
        private T[] array = new T[100];
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

    }
    class Indexer
    {
        static void Main(string[] args)
        {
            var myString = new Mycollection<string>();
            myString[0] = "Hello World";
            myString[1] = "Hello C#";
            myString[1] = "Hello Indexer";
            for (int i = 0; i < 3; i++) Console.WriteLine(myString[i]);
        }
    }
}
