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
            int sayi, fakt = 1;
            Console.Write("Say� Giriniz = ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                fakt = fakt * i;
            }
            Console.WriteLine("Say�n�z = {0}", fakt);
        }
    }
}
