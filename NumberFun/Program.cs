using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Enter number 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Number 1 * number 2 = " + (num1 * num2));
            Console.WriteLine("Number 1 + number 2 = " + (num1 +num2));
            Console.WriteLine("Number 1 + number 2 = " + (num1 - num2));
            Console.WriteLine("Number 1 + number 2 = " + (num1 / num2));
            Console.ReadKey();

        }
    }
}
