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
            Console.Write("L�tfen Birinci say�y� giriniz : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("L�tfen �kinci say�y� giriniz : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("L�tfen Se�im Yap�n�z\n1.Toplama\n2.��kartma\n3.�arpma\n4.B�lme\nSe�iminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("�ki say�n�n toplam� = {0}", sonuc = num1 + num2); //case 4 e kadar hepsi if else 

                    break;
                case 2:
                    Console.WriteLine("�ki say�n�n toplam� = {0}", sonuc = num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("�ki say�n�n toplam� = {0}", sonuc = num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("�ki say�n�n toplam� = {0}", sonuc = num1 / num2);
                    break;
                default:
                    Console.WriteLine("Hatal� i�lem Se�tiniz ..."); // defaulta else desek yan�lmay�z...
                    break;
            }
            Console.ReadLine();
        }
    }
}
