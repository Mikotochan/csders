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
            try
            {
                float sayi, sonuc, yuzde;
                Console.Write("Sayý Giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yüzde Giriniz : ");
                yuzde = Convert.ToInt32(Console.ReadLine());
                sonuc = ((sayi * yuzde) / (100));
                Console.WriteLine("Sonucunuz : {0}", sonuc);
            }

            catch
            {

                Console.WriteLine("Somethings Went Wrong :( ");
            }
        }
    }
}
