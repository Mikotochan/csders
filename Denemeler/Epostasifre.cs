using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {




                string sifre;
                string ID;
                do
                {
                    Console.Write("E-Posta Giriniz : ");
                    ID = Console.ReadLine();
                    Console.Write("�ifreyi Giriniz : ");
                    sifre = Console.ReadLine();
                    Console.WriteLine("Tekrar Deneyiniz ");
                } while (sifre != ("merh") || ID != ("orhan@gmail.com"));
                Console.WriteLine("�ifreyi Do�ru \nPrograma Y�nlendiriliyorsunuz ");



                int i = 5;
                while (true)
                {
                    Console.WriteLine("Merhaba !");
                    i++;
                }




            }


            catch
            {
                Console.Write("Bir �eyler Ters Gitti ");
            }

        }
    }
}
