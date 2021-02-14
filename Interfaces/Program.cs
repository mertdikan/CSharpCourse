using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ahmet selim",
                LastName="canpolat",
                Adress="istanbul"

            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "mert1",
                LastName= "dikan",
                Departmant= "ktü"
            
            };
            manager.Add(student);
            manager.Add(customer);
           
            //burası gerçek hayat örneği
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());


            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MYsqlCustomerDal()

            };

            foreach (var customerDal in customerDals)
           
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
