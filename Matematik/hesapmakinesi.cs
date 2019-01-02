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
            int a, b, c, d;

            Console.Write("Lütfen Birinci Sayýyý Giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Ýkinci Sayýyý Giriniz : ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            d = a - b; 
            Console.WriteLine("Toplama Sonucunuz " + c.ToString());
            Console.WriteLine("Çýkartma Sonucunuz " + d.ToString());
            Console.ReadLine();
        }
    }
}
