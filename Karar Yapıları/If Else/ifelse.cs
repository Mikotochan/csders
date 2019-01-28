using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Notunuzu Giriniz : ");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not < 0 || not > 100)
            {
                Console.WriteLine("Yanlýþ Deðer Girdiniz ");

            }
            else if (not > 90)
            {
                Console.WriteLine("Notunuz A");
            }
            else if (not > 80)
            {
                Console.WriteLine("Notunuz B");
            }


            else if (not > 70)
            {
                Console.WriteLine("Notunuz C");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Notunuz D");
            }
            else
            {
                Console.WriteLine("Hiçbir Dersi Geçemedin Loserr!!!");
            }



        }
    }
}
