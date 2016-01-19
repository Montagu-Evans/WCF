using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.Age.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAgeClient host = new CalculateAgeClient();
            System.Console.WriteLine("Enter your year: ");
            var year = System.Console.ReadLine();
            System.Console.WriteLine("Enter your month: ");
            var month = System.Console.ReadLine();
            System.Console.WriteLine("Enter your day: ");
            var day = System.Console.ReadLine();
            var date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            System.Console.WriteLine(host.CalculateAge(date));
        }
    }
}
