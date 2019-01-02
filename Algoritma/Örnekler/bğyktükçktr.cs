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
            Console.WriteLine("Bir Sayý Giriniz ; ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 100)
            {
                Console.WriteLine("Sayý Büyüktür");
            }
            else
            {

                Console.WriteLine("Sayý Küçük");
            }
            Console.ReadLine();

        }
    }
}
