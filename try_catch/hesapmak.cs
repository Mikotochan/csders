using System;
namespace xperia
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.Write("B�R�NC� SAYIYI GIRIN ");
                int abc = Convert.ToInt32(Console.ReadLine());
                Console.Write("B�R�NC� SAYIYI GIRIN ");
                int cba = Convert.ToInt32(Console.ReadLine());
                int cbaq;
                cbaq = abc + cba;
                Console.WriteLine(cbaq);
            }

            catch
            {
                Console.WriteLine("Something's Went Wrong");
                Console.ReadKey();
            }
            Console.ReadKey();

        }

    }
}