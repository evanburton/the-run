using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_program
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            Console.WriteLine("please enter your age");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            //calculation
            int age = DateTime.Today.Year - birthday.Year;

            //selection
            if (age >= 0 && age < 13)
            {
                Console.WriteLine("you are a child");
            }

            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("you are a teenager");
             
            }            
            else          
            {
                Console.WriteLine("you are an adult");
            }

            //wait
            Console.ReadLine();
        }
    }
     
}
