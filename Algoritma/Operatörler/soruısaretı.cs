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
            Console.Write("Programlama e�lencelimi ? (e,h)");
            string a = Console.ReadLine();


            Console.Write(a == "e" ? "Bravo " : "Sa�l�k olsun");

            Console.ReadLine();
        }
    }
}
