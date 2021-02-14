using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "bilgisayar");

            Console.WriteLine(dictionary["Table"]);
            Console.WriteLine("---------------------------");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine("---------------------------");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("---------------------------");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));


            Console.ReadLine();
        }
    }
}
