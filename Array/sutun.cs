using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpkl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] merhaba = new int[3, 2] { { 50, 60 }, { 70, 80 }, { 40, 30 } };
            Console.WriteLine("1.Sat�r 1.Eleman : {0}", merhaba[0, 0]);
            Console.WriteLine("2.Sat�r 2.Eleman : {0}", merhaba[1, 1]);
            Console.WriteLine("3.Sat�r 1.Eleman : {0}", merhaba[2, 0]);
            Console.ReadKey(true);
        }
    }
}
