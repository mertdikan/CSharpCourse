using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        protected  int Id { get; set; }
        public void Save()
        {
            
        }
        public void Delete()
        {

        }
    }

    class Student: Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}
