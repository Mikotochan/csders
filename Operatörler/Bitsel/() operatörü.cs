using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kalem Sayýsý Giriniz : ");
            int a = Convert.ToInt32(Console.ReadLine());
            string str1 = "kalem";
            str1 = str1 + (a == 1 ? " " : "ler");
            Console.WriteLine(str1);

        }
    }
}
