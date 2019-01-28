using System;

namespace denmeler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 254;
            byte b2 = (byte)~b1; //11111110 = 00000001
            Console.WriteLine(b2);

        }
    }
}
