using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceDemo;

namespace SelfServiceHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine($"Service started {DateTime.Now.ToShortTimeString()}");
                Console.WriteLine("Press ENTER to terminate!");
                Console.ReadLine();   
            }
        }
    }
}
