using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello \nthis is Ansh Agrawal");

            //this is one Line comment on c sharp 
            /* this is a multi line comment on c sharp
             * haan yhi h bee multi line comment 
             */

            Console.Write("This is a single line output ");


            // data types in c sharp

            /*
             * Integer -- > 4 bytes
             * Long     -- > 8 bytes
             * FLoating --> 4 bytes
             * Double --> 8 bytes
             * Char --> 2 bytes
             * String  --> 2 bytes per character
             * Boolean --> 1 bit
             */

            string input = Console.ReadLine(); // takes input from the user in string format

            Console.WriteLine("You entered: " + input); // outputs the input back to the user

        }
    }
}
