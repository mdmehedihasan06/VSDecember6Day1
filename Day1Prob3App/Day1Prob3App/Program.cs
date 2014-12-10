using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Prob3App
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter First Value:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value:");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Small value is:{0}",num2);
                Console.WriteLine("Large value is:{0}",num1);
                Console.ReadLine();
            }
            else if (num1 == num2)
            {
                Console.WriteLine("num1 & num2 are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Small value is:{0}", num1);
                Console.WriteLine("Large value is:{0}", num2);
                Console.ReadLine();
            }
        }
    }
}
