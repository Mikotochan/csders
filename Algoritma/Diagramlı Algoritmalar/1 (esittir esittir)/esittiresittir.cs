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
            Console.Write("Say� giriniz : ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 5) //e�er != �eklinde bir ifade yazmam�z gereksedi;
            {
                Console.WriteLine("Say� 5 ' e e�ittir "); //�f ve Elsedeki alanlar�n yerini de�i�tirmemiz gerekecekti...
            }
            else
            {
                Console.WriteLine("Say� 5 ' e e�it de�ildir. ");
            }
            Console.ReadLine();
        }
    }
}
