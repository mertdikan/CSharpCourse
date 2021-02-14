using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            //if (number==10)
            //{
            //    Console.WriteLine("number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("number is not 10");
            //}
            //Console.ReadLine();
            if (number >= 0 && number <= 100) 
            {
                Console.WriteLine("number is between 0-100");
            }
         
            Console.ReadLine();
        }
    }
}
