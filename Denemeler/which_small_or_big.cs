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



            Console.Write("Birinci Say�y� Giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("�kinci Say�y� Giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            bool kontrol;
            kontrol = sayi1 > sayi2;
            if (kontrol == true)
            {
                Console.WriteLine("En B�y�k Say� : : Birinci Girilen Say�d�r");
            }


            else if (sayi1 == sayi2)
            {
                Console.WriteLine("�ki Say� Birbirine E�ittir. ");
            }
            else
            {
                Console.WriteLine("En K���k Say� : : Birinci Girilen Say�d�r");
            }
        }
    }
}
