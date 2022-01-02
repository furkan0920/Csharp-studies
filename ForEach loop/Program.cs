using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler= { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };

            //for(int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}


            //foreach (string a in isimler)
            //{
            //    Console.WriteLine(a);
            //}

            double[] ondalikli_sayilar = { 10.4, 0.96, 14.5, 74.1 };

            foreach (double b in ondalikli_sayilar)
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
