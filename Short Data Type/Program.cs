using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //The short variable can store -32768 to 32767 values

            short firstVariable = -50;

            short secondVariable = 25550;

            short thirdVariable = 32000;

            short MaxValue = short.MaxValue;

            short MinValue = short.MinValue;

            Console.WriteLine(MaxValue);
            Console.WriteLine(MinValue);

            Console.ReadLine();

        }
    }
}
