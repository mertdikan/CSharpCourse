using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string [2] { "Ankara", "İstanbul" };
            //cities = new string[3];

            //Console.WriteLine(cities[0]);

            List<string> cities2 = new List<string>();
            cities2.Add("Ankara");


            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Trabzon");

           

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(cities[3]);

            List<Customer> customer1 = new List<Customer>
            {
                new Customer{Id=1,FirstName="Mert"},
                new Customer{Id=2,FirstName="Dikan"}
            };

            var count = customer1.Count;
            
            
            
            
        

            Console.ReadLine();
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}
