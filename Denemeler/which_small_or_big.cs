using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;



            Console.Write("Birinci Sayýyý Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ýkinci Sayýyý Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            bool kontrol;
            kontrol = sayi1 > sayi2;
            if (kontrol == true)
            {
                Console.WriteLine("En Büyük Sayý : : Birinci Girilen Sayýdýr");
            }


            else if (sayi1 == sayi2)
            {
                Console.WriteLine("Ýki Sayý Birbirine Eþittir. ");
            }
            else
            {
                Console.WriteLine("En Küçük Sayý : : Birinci Girilen Sayýdýr");
            }
        }
    }
}
