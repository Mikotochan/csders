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
            {

                try
                {
                    Console.Write("Dik Üçgen Oluþturmaya hoþgeldiniz lütfen satýr giriniz : ");
                    int satir = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= satir; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                }

                catch
                {
                    Console.WriteLine("Something went wrong try again later...");
                }

                finally
                {
                    Console.WriteLine("çýkmak için entere basýn");

                    Console.ReadLine();
                }
            }

        }
    }
}
