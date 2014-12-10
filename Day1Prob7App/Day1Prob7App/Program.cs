using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Prob7App
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            Console.WriteLine("Enter lower limit:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper limit:");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i = min; i < max; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}
