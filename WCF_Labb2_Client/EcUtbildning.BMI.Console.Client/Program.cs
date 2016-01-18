using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.BMI.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateBmiClient host = new CalculateBmiClient();
            System.Console.WriteLine();

            System.Console.WriteLine("Vikt(antal kg): ");
            int weight = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Längd: ");
            double length = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine(host.CalculateBmi(weight, length));
            System.Console.ReadLine();
        }
    }
}
