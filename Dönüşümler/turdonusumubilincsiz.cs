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
            b = a; //Geçerli, küçük büyüðe doðrudan eþitlenebilir
            a = b; //Hatalý, tip dönüþümü gerekli
            d = b; //Geçerli, double tipi int tipini kapsýyor
            b = d; //Hatalý, tip dönüþümü gerekli
            Console.ReadKey();

        }
    }
}
