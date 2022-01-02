using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Or_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // or operator : || 
            int number1 = 5;
            int number2 =5;
            int number3 = 10;

            bool CheckIt = number1 == number2 || number3 < number1;

            Console.WriteLine(CheckIt);
            Console.ReadLine();
        }
    }
}
