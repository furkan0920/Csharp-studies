using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();


            int a = 100;
            while (a >= 0)
            {
                Console.WriteLine(a);
                a -= 2;
            }
            Console.ReadLine();
        }
    }
}
