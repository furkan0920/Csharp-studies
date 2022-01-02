using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 7055, 65, 5, 20, 35, 65, 5, 20, 35, 65, 60 };
            int adet = 0;
            int sayi;

            Console.Write("Lütfen bir sayi giriniz : ");

            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiginiz deger dizide bulunamadı....");
            }
            else
            {
                Console.WriteLine("Girdiginiz sayi dizide bulundu...");
                Console.WriteLine("Adet: " +adet);
            }
            Console.ReadLine();
        }
    }
}
