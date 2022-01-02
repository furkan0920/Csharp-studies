using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;

            //} while (a<=10);
            //Console.ReadLine();


            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a<=100);
            Console.WriteLine("1 'den 100 'e kadar olan sayilarin toplami: "+toplam);
            Console.ReadLine();
               

            
            
           
        }
    }
}
