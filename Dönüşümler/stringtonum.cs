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
            string s = "";
            byte a = Byte.Parse(s); //string – byte dönüþümü  
            short b = Int16.Parse(s); //string – short dönüþümü  
            ushort c = UInt16.Parse(s); //string – ushort dönüþümü 



            Console.WriteLine(a);
            Console.Read();

        }
    }
}
