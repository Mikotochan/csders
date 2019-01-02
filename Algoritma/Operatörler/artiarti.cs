using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orhanss
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            int a = 10;
            int b;
            int c;

            b = a++;
            c = ++a;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = {0}",b);
            Console.WriteLine("c = {0}",c);
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
