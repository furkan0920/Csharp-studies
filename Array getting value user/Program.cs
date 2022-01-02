using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_getting_value_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayilar dizisinin "+(i+0)+".index degerini giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine( "***************************************");
            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
