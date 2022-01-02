using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // && and operator shift+6
            // tam olmadı bu
            
            int number1 = 5;

            int number2 = 5;

            int number3 = 20;

            bool CheckIt = number1 == number2 && number1 > number3;

            Console.WriteLine(CheckIt);
            Console.ReadLine();
        }
    }
}
