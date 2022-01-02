using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter exam1");
            int exam1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter exam2");
            int exam2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter exam3");
            int exam3 = Convert.ToInt32(Console.ReadLine());

            int conclusion = (exam1 + exam2 + exam3) / 3;
            
            if (conclusion>80 && conclusion<100)
            {
                Console.WriteLine("Exam value: A+");
                Console.ReadLine();
            }
            else if(conclusion>60 && conclusion < 80)
            {
                Console.WriteLine("Exam value: A");
            }
            else if (conclusion > 40 && conclusion < 60)
            {
                Console.WriteLine("Exam value: B+");
            }
            else
            {
                Console.WriteLine("Exam value: F");
            }


            Console.ReadLine();
            
        }
    }
}
