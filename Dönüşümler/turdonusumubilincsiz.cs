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
            byte a = 100; int b = 500; double d = 2.5;
            b = a; //Ge�erli, k���k b�y��e do�rudan e�itlenebilir
            a = b; //Hatal�, tip d�n���m� gerekli
            d = b; //Ge�erli, double tipi int tipini kaps�yor
            b = d; //Hatal�, tip d�n���m� gerekli
            Console.ReadKey();

        }
    }
}
