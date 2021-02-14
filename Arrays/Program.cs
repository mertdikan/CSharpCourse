using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "engin";
            //students[1] = "derin";
            //students[2] = "salih";

            string[] students2 = new[] { "engin", "mert", "dikan" };
            
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
       
    }

   
}
