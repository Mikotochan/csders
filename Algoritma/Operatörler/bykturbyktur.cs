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

            Console.ForegroundColor = ConsoleColor.Green;

            byte d = 5;
            byte f = (byte)(d << 1); /* 5 say�s� 0000101 �eklindedir << say�y� bir sat�r atmay� g�sterir
                                       yani 00001010   olur. */


            Console.Write(f);

            Console.ReadLine();
        }
    }
}
