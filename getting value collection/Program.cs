using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_value_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");

            int number = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;


            for(int i = 1; i <= number; i++)
            {
                toplam += i; 
            }
            double ortalama = toplam / number;

            if (ortalama>50)
            {
                Console.WriteLine("Ortalamaniz 50 den buyuktur...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalamaniz 50 den kucuktur...");
                Console.ReadLine();
            }


        }
    }
}
