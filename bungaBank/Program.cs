using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bungaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            double bunga = 0.00;
            double deposit = 1000000;
            double persentage = 1;            
            int i = 1;
            BungaBankUsingLoop(bunga, deposit, persentage, i);
            Console.ReadKey();
        }

        public static void BungaBankUsingLoop(double bunga, double deposit, double persentage,int i)
        {
            Console.WriteLine("Hasil Dengan Looping");
            int n = 12;
            for (int j = 0; j < n; j++)
            {
                bunga = (deposit * 1) / 100;
                deposit = deposit + bunga;
            }
            Console.WriteLine("Input \t " + n);
            Console.WriteLine("Output \t " + deposit);
        }
    }
}
