using System;

namespace denmeler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string snumb1, snumb2;
                int inumb1, inumb2, total;
                Console.Write("Enter First Number : ");
                snumb1 = Console.ReadLine();
                Console.Write("Enter Second Number : ");
                snumb2 = Console.ReadLine();

                inumb1 = Convert.ToInt32(snumb1);
                inumb2 = Convert.ToInt32(snumb2);

                total = (inumb1 + inumb2);

                Console.WriteLine("Your Total : {0}", total);
            }
            catch
            {
                Console.WriteLine("Somethings Went Wrong Plase Again Later !");
            }






        }
    }
}
