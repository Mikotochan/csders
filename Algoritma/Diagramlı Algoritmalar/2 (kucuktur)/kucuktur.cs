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
            Console.Write("De�er giriniz : ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10) // > kullansayd�k a�a��daki bloklar�da de�i�tirmemiz gerekirdi.
            {
                Console.WriteLine("Bu bir rakamd�r. ");
            }
            else
            {
                Console.WriteLine("Bu bir say�d�r. ");
            }
            Console.ReadLine();
        }
    }
}
