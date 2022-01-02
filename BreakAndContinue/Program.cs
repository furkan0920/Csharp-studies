using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break: döngüyü kırar ve çıkar
            // continue: döngüdeki o sayıyı atlar yazmaya devam eder.Döngüyü bir kez kırar
            for(int i = 1; i <= 10; i++)
            {
                if (i==7)
                {
                    //break;
                    continue;
                }
                Console.WriteLine("i'nin degeri:"+i);
            }
            Console.ReadLine();
        }
    }
}
