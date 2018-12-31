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
            int z, x, y;
            Console.Write("Birinci sayý giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ýkinci sayý giriniz: ");
            y = Convert.ToInt32(Console.ReadLine());

            z = (x + y);
            Console.Write(z);


            Console.ReadLine();

        }
    }
}
