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
            Console.Write("bir say� giriniz : ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdi�ini say� : {0} ", a);
            }

            catch
            {
                Console.WriteLine("L�tfen �nteger Bir ifade giriniz.");
            }
            finally
            {
                Console.WriteLine("��k�� i�in bir tu�a bas�n�z.");
                Console.ReadLine();
            }

        }
    }
}
