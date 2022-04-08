using System;

namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
            var a = new MyType<int>();
            a.Add(1);
            a.Add(5);
            a.Add(15);
            a.Add(8);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
