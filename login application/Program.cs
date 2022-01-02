using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanici adinizi giriniz");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Sifrenizi giriniz");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == "enes" && sifre == "123")
                {
                    Console.WriteLine("Tebrikler basarili bir sekilde giris yaptiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanici adiniz veya sifreniz yanlis");
                    if (hak_sayisi>0)
                    {
                        hak_sayisi -= 1;
                    }
                    if (hak_sayisi == 0)
                    {
                        Console.WriteLine("Giris hak sayiniz dolmustur giris yapamazsiniz");
                        break;
                    }
                    
                }
            }
            Console.ReadLine();
        }
     
    }
}
