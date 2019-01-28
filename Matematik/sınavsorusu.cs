using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, fakt = 1; // ((n-2)!/n) + (n*2)
            Console.Write("Sayý Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            int blopp = sayi - 2;
            for (int i = 1; i <= blopp; i++)
            {
                fakt = fakt * i;
            }
            double treaker = (fakt / sayi) + (sayi * 2);
            Console.Write(treaker);


            Console.ReadLine();
        }
    }
}
