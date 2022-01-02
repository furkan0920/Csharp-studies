using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {


            //İNT VERİ TİPİNDEN BYTE VERİ TİPİNE DÖNÜŞÜM
            //int a=500 ;

            //byte b = (byte)a;

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b);
            //Console.ReadLine();



            //STRİNG VERİ TİPİNDEN İNT VERİ TİTPİNE DÖNÜŞÜM 

            //string number1 = "1";
            //string number2 = "2";

            //int a = int.Parse(number1);
            //int b = int.Parse(number2);
            //Console.WriteLine(a+b);


            //int a = Convert.ToInt32(number1);
            //int b = Convert.ToInt32(number2);

            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //İNT VERİ TİPİNDEN STRİNG VERİ TİPİNE DÖNÜŞTÜRME YAPACAĞIZ 
            //string yanayana yazdırır

            //int number1 = 5;
            //int number2 = 10;

            //string a = number1.ToString();
            //string b = number2.ToString();

            //Console.WriteLine(a+b);
            //Console.ReadLine();

            //DOUBLE VERİ TİTPİNDEN İNT VERİ TİPİNE DÖNÜŞÜM

            //double number = 5.22;

            //int a = Convert.ToInt32(number);

            //Console.WriteLine( a);
            //Console.WriteLine(a.GetType());
            //Console.ReadLine();

            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR

            //Console.WriteLine("enter old");

            //string kullanici_yas = Console.ReadLine();
            //int kullanici_yasInt = int.Parse(kullanici_yas);
            //int kullaici_yasInt2 = Convert.ToInt32(kullanici_yas);

            //Console.WriteLine(kullanici_yas);
            //Console.WriteLine(kullaici_yasInt2);
            //Console.ReadLine();



            //KULLANICIDAN 2 TANE SAYI ALAN VE İKİSİNİN TIOPLAMINI EKRANA YAZDIRAN PROGRAMI YAZINIZ

            Console.WriteLine("enter number1");
            string number1 = Console.ReadLine();

            int a = int.Parse(number1);

            Console.WriteLine("enter number2");
            string number2 = Console.ReadLine();

            int b = int.Parse(number2);

            Console.WriteLine("İki sayinin toplmı:"+(a+b) );
            Console.ReadLine();

        }
    }
}
