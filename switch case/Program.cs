using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;


            Console.WriteLine("1-Bakiye Görüntüle");
            Console.WriteLine("2-Para cek");
            Console.WriteLine("3-Para yatır");
            Console.WriteLine("4-cıkıs yap");

            Console.WriteLine("Yapmak istedginiz islemi seciniz");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz:" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Cekmek istediginiz tutar");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para cekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz:" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatirmak istediginiz tutari giriniz");
                    int yatırılacaktutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatırılacaktutar));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Hesabinizdan cikis yapiliyor iyi günler");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("lütfen gecerli deger giriniz");
                    Console.ReadLine();
                    break;


                   

            }

        }
    }
}
