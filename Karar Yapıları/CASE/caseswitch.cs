using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Sayý Giriniz : ");
            int b = Convert.ToInt32(Console.ReadLine());


            switch (b)
            {
                case 1:


                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Birler Tablosu : {0} ", i * 1);
                    }


                    break;

                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Ýkiler Tablosu : {0}", i * 2);
                    }
                    break;
                default:
                    Console.WriteLine("Yanlýþ Deðer");
                    break;


            }

        }


    }
}
