using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi, fakt = 1;
            Console.Write("Say� giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= sayi; i++)
            {
                fakt = fakt * i;
            }
            Console.Write("Sonu�:" + fakt);

        }
    }
}
