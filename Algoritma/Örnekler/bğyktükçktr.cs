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
            Console.WriteLine("Bir Say� Giriniz ; ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 100)
            {
                Console.WriteLine("Say� B�y�kt�r");
            }
            else
            {

                Console.WriteLine("Say� K���k");
            }
            Console.ReadLine();

        }
    }
}
