using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = { "Enes", "Yasin", "Mehmet", "Ercan", "Kasım" };

            //for( int i=0; i <= isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //Console.ReadLine();


            //char[] karakter = { 'K', 'E', 'M', 'A', 'L' };

            //for(int i = 0; i <= karakter.Length; i++)
            //{
            //    Console.WriteLine(karakter[i]);
            //}
            //Console.ReadLine


            double[] ondalikli_sayilar = { 1.69, 0.96, 4.85, 6.78 };

            for(int i = 0; i < ondalikli_sayilar.Length; i++)
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }
            Console.ReadLine();

        }
    }
}
