using System;

namespace denmeler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a1 = 255;               //11111111
            byte a2 = 3;                 //00000011
            int c = (byte)(a1 & a2);     //00000011 --------- | kullanýlýrsa 1 baskýn olur
            Console.WriteLine(c);     //00000011
        }
    }
}
