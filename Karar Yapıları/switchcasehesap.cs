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
            double sonuc = 0;
            int num1 = 0, num2 = 0;
            Console.Write("Lütfen Birinci sayýyý giriniz : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Ýkinci sayýyý giriniz : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Seçim Yapýnýz\n1.Toplama\n2.Çýkartma\n3.Çarpma\n4.Bölme\nSeçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Ýki sayýnýn toplamý = {0}", sonuc = num1 + num2); //case 4 e kadar hepsi if else 

                    break;
                case 2:
                    Console.WriteLine("Ýki sayýnýn toplamý = {0}", sonuc = num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("Ýki sayýnýn toplamý = {0}", sonuc = num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("Ýki sayýnýn toplamý = {0}", sonuc = num1 / num2);
                    break;
                default:
                    Console.WriteLine("Hatalý iþlem Seçtiniz ..."); // defaulta else desek yanýlmayýz...
                    break;
            }
            Console.ReadLine();
        }
    }
}
