using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Say� Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool control1, control2;
            control1 = sayi % 4 == 0;
            control2 = sayi % 2 == 0;
            if ((control1 && control2) == (true))
            {
                Console.WriteLine("Say�lar 4 Ve 2 Ye Tam B�l�nebilirler");
            }
            else
            {
                Console.WriteLine("Say�lar 4 Ve 2 Ye Tam B�l�nebilemezler");
            }
        }
    }
}
