using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            


            
                List<string> students = new List<string> { "engin", "derin", "salih" };

                if (!students.Contains("Ahmet"))
                {
                    throw new RecordNotFoundException();
                }
                else
                {
                    Console.WriteLine("Record Found");
                }
           
       
            

            try
            {
                string[] students = new string[3] { "mert", "dikan", "dikan2" };
                students[3] = "ahmet";

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            
            Console.ReadLine();

        }
    }
}
