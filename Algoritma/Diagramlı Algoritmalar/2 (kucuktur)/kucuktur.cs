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
            Console.Write("Deðer giriniz : ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10) // > kullansaydýk aþaðýdaki bloklarýda deðiþtirmemiz gerekirdi.
            {
                Console.WriteLine("Bu bir rakamdýr. ");
            }
            else
            {
                Console.WriteLine("Bu bir sayýdýr. ");
            }
            Console.ReadLine();
        }
    }
}
