using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Atm_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atm'ye hoşgeldininz");
            Console.WriteLine("Yapmak istedginiz islemi seciniz");
            Console.WriteLine();
            Console.WriteLine("1-Suanki bakiye degeriniz");
            Console.WriteLine("2-Cekmek istediginiz tutrı giriniz");
            Console.WriteLine("3-Yatirmak istediginiz tutarı giriniz");
            Console.WriteLine("q-cıkıs icin tıklayınız");

            int bakiye = 1000;
            
            string secim = Console.ReadLine();

            if (secim == "1") 
            {
                Console.WriteLine("Suanki bakiye degeriniz" +bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek istediginiz tutarı giriniz" );
                int cekilecek_tutar= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan tutar: " +(bakiye-cekilecek_tutar));

                if (cekilecek_tutar < bakiye)
                {
                    Console.WriteLine("Kalan tutar:" + (bakiye-cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("bakiyenizden fazla para cekemezsiniz");
                }

            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatirmak istediginiz tutarı giriniz");
                int yatıracalak_tutar = Convert.ToInt32(Console.ReadLine()) ;
               
                Console.WriteLine("Toplam bakşyeniz"+(bakiye+yatıracalak_tutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("Atm den cikis yapılıyor");
                Console.WriteLine("Cikis yapildi iyi gunler");
            }
            else
            {
                Console.WriteLine("Lutfen gecerli deger giriniz");
            }
            Console.ReadLine();
              
        }
    }
}
//36.derrs
