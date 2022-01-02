using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter note");

            string note = Console.ReadLine();

            int a = Convert.ToInt32(note);

            if (a>50)
            {
                Console.WriteLine("Exam pass");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Exam fail");
                Console.ReadLine();
            }

            
        }
    }
}
