using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametresiz- geriye deger döndürmeyen metot tanımlama....
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            adınıyazdır();
        }
        static void Selamver()
        {
            Console.WriteLine("Selamlar :)");
            Console.ReadLine();
        }
        
        static void adınıyazdır()
        {
            Console.WriteLine("Furkan");
            Console.ReadLine();
        }
    }
}
