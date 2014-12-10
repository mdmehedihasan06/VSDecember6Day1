using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Prob2App
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2;
            Console.WriteLine("Enter First value:");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second value:");
            value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of Addition :{0}", value1+value2);
            Console.WriteLine("Result of Subtraction :{0}", value1-value2);
            Console.WriteLine("Result of Multiplication :{0}", value1*value2);
            Console.WriteLine("Result of Division :{0}", value1/value2);
            Console.ReadLine();
        }
    }
}
