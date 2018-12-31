using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fart
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 255;
            byte b;

            checked { b = (byte)i; } // bu satır veri kaybı kontrolu sağlamaktadır...

            Console.WriteLine(i);





            Console.Read();
        }
    }
}
