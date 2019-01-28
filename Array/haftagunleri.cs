using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpkl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] haftagunsayýlarý = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler = new string[7] { "Pazartesi", "Salý", "Çarþamba", "Perþembe", "Cuma", "Cumartesi", "Pazar" };
            Console.WriteLine("Haftanýn {0}.Günü {1},Gününe Eþittir.", haftagunsayýlarý[5], gunler[5]);
        }
    }
}
    