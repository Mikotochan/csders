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
            string[] programming = new string[7] { "C#", "Ruby", "Css", "Java", "JavaScript", "C,C++", "Swift" };
            foreach (string eleman in programming)
            {
                Console.WriteLine("{0}", eleman);
            }
            Console.ReadKey(true);
        }
    }
}
