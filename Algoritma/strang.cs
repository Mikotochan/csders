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
            int T = 0;
            int S = 0;
            bool kontrol = true;

            while (kontrol)
            {




                if (S > 10)

                {
                    Console.WriteLine(T);

                    kontrol = false;
                }

                else
                {
                    S = S + 1;
                    T = T + S;




                }
            }

            Console.ReadLine();

        }
    }
}
