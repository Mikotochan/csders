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


            int s = 0;
            bool kontrol = true;
            while (kontrol)
            {


                Console.Write("Bir Say� Giriniz : ");
                int a = Convert.ToInt32(Console.ReadLine());




                if (a == 0)
                {
                    Console.Write("Girdi�iniz Say�lar�n Adeti : " + s);
                    kontrol = false;


                }
                else
                {
                    s = s + 1;


                }

            }
            Console.ReadLine();

        }
    }
}
