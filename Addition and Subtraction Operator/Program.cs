using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_and_Subtraction_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition Operator =+
            //Subtraction Operator =-

            int number1 = 5;
            int number2 = 12;
            int number3 = 18;
            int number4 = 20;

            int conclusion = (number1 + number2+number3)- number4;

            Console.WriteLine(conclusion);

            Console.ReadLine();
        }
    }
}
