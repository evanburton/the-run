using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {

            // generate random number from 1 to 100
            Random rnd = new System.Random();
            int randomnumber = rnd.Next(1, 101);

            // set guess to number out of random range
            int guess = -1;

            // start loop
            while (guess != randomnumber)
            {

                //input
                guess = int.Parse(Console.ReadLine());

                //selection
                if (guess > randomnumber)
                {
                    Console.WriteLine("too high!");
                }
                else if (guess < randomnumber)


            }

        }
   
    }
}
