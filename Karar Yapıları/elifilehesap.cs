using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xperia
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 0;
            int num1 = 0;
            int num2 = 0;


            Console.Write("Birinci Say�y� Giriniz : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("�kinci Say�y� Giriniz : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Se�im Yap�n�z\n1.Toplama\n2.��kartma\n3.�arpma\n4.B�lme\nSe�iminiz ?");
            int secim = Convert.ToInt32(Console.ReadLine());




            if (secim == 1)
            {
                Console.Write("Toplama Sonucunuz = {0}", sonuc = num1 + num2);
            }
            else if (secim == 2)
            {
                Console.Write("��kartma Sonucunuz = {0}", sonuc = num1 - num2);
            }
            else if (secim == 3)
            {
                Console.Write("�arpma Sonucunuz = {0}", sonuc = num1 * num2);
            }
            else if (secim == 4)
            {
                Console.Write("Toplama Sonucunuz = {0}", sonuc = num1 / num2);
            }



        }
    }
}