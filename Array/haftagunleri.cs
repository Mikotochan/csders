using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lpkl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] haftagunsay�lar� = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler = new string[7] { "Pazartesi", "Sal�", "�ar�amba", "Per�embe", "Cuma", "Cumartesi", "Pazar" };
            Console.WriteLine("Haftan�n {0}.G�n� {1},G�n�ne E�ittir.", haftagunsay�lar�[5], gunler[5]);
        }
    }
}
    