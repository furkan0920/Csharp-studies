using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body_kitle_indesk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lutfen kilonuzu giriniz: ");
            double boy = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Lutfen boyunnuzu giriniz: ");           
            int kilo = Convert.ToInt32(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayif");
                Console.ReadLine();
            }
            else if (bke<25 && bke > 18)
            {
                Console.WriteLine("Normal");
                Console.ReadLine();
            }
            else if (bke > 25)
            {
                Console.WriteLine("Obez");
                Console.ReadLine();
            }
           

        }
    }
}
