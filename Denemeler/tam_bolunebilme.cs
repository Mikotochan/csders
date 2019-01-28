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

            Console.Write("Sayý Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool control1, control2;
            control1 = sayi % 4 == 0;
            control2 = sayi % 2 == 0;
            if ((control1 && control2) == (true))
            {
                Console.WriteLine("Sayýlar 4 Ve 2 Ye Tam Bölünebilirler");
            }
            else
            {
                Console.WriteLine("Sayýlar 4 Ve 2 Ye Tam Bölünebilemezler");
            }
        }
    }
}
