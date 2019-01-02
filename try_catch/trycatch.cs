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
            int a;
            Console.Write("bir sayý giriniz : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiðini sayý : {0} ", a);
            }

            catch
            {
                Console.WriteLine("Lütfen Ýnteger Bir ifade giriniz.");
            }
            finally
            {
                Console.WriteLine("çýkýþ için bir tuþa basýnýz.");
                Console.ReadLine();
            }

        }
    }
}
