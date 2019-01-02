using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xperia
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazi;
            do
            {
                Console.Write("Þifreyi giriniz : ");
                yazi = Console.ReadLine();

            } while (yazi != "re");
            Console.WriteLine("Þifreyi Bildin !");
        }
    }
}