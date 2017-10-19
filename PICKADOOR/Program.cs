using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICKADOOR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" pick a door");
            string choice = Console.ReadLine();

            if ( choice == "1")
            {
                Console.WriteLine(" behind door 1 is donald trump");                                    
            }
            else if (choice == "2")
            {
                Console.WriteLine(" behind door 2 is a dog");
            }
            else if (choice == "3")
            {
                Console.WriteLine(" behind door 3 is a wall ");
            }
            else
            {
                Console.WriteLine(" behind door 3 is a wall ");      
            }

            Console.ReadLine();
        }
    }
}
