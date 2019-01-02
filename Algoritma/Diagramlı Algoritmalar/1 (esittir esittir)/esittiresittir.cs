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
            Console.Write("Sayý giriniz : ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 5) //eðer != þeklinde bir ifade yazmamýz gereksedi;
            {
                Console.WriteLine("Sayý 5 ' e eþittir "); //Ýf ve Elsedeki alanlarýn yerini deðiþtirmemiz gerekecekti...
            }
            else
            {
                Console.WriteLine("Sayý 5 ' e eþit deðildir. ");
            }
            Console.ReadLine();
        }
    }
}
