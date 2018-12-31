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

            int satir;
            Console.Write("Satýr Giriniz : ");
            satir = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < satir; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
