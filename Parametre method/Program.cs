using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametre_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametre alan - geriye deger döndürmeyen method yazma

            toplamaYap(5,7);
            carpmaYap(5, 8, 7);
            isimSoyisim("Furkan","Ayakdas");
            Console.ReadLine();
        }
        static void toplamaYap(int sayi1,int sayi2)
        {
            Console.WriteLine("Girilen sayilarin toplami: "+(sayi1+sayi2));
        }

        static void carpmaYap(int sayi1,int sayi2,int sayi3)
        {
            Console.WriteLine("Girilen sayilarin carpımı: "+(sayi1*sayi2*sayi3));
        }

        static void isimSoyisim(string isim,string soyisim)
        {
            Console.WriteLine("Isminiz ve soyisiminiz: "+isim+" " + soyisim);
        }
    }
}
