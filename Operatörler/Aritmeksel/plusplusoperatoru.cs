using System;

namespace denmeler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b, c;
            b = a++;
            c = ++a;
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("c :  {0}", c);
        }
    }
}
