using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entered_number_odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int teksayilarintoplami = 0;
            int ciftsayilarintoplami = 0;

            int kullanicideger;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i+0)+". index degerini giriniz: ");
                kullanicideger = int.Parse(Console.ReadLine());

                sayilar[i] = kullanicideger;  //dizimi kullanicidan aldıgım degerle doldurdum
            }

            for(int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    ciftsayilarintoplami += sayilar[j];
                }
                else
                {
                    tekAdetToplam++;
                    teksayilarintoplami += sayilar[j];
                }
            }
            if (ciftsayilarintoplami > teksayilarintoplami)
            {
                Console.WriteLine("Cift sayilarin toplami tek sayilarin toplamindan buyuyktur");
            }
            else
            {
                Console.WriteLine("Tek sayilairn toplami cift sayilarin toplamindan buyuktur");
            }

            Console.WriteLine("**********************************");

            Console.WriteLine("cift sayilarin toplami: "+ciftsayilarintoplami);
            Console.WriteLine("cift sayilarin adeti: "+ciftAdetToplam);

            Console.WriteLine("**********************************");

            Console.WriteLine("tek sayilari toplami: "+teksayilarintoplami);
            Console.WriteLine("tek sayilarin adeti: "+tekAdetToplam);

            Console.ReadLine();
        }
    }
}
