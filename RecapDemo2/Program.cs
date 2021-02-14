using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new Smslogger();
            customerManager.Add();
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public Ilogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }
    class DatabaseLogger:Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database!");
        }
    }
    
    class Filelogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class Smslogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }


    interface Ilogger
    {
        void Log();
    }
}
