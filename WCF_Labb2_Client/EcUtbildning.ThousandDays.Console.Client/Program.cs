using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.ThousandDays.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateThousandDaysClient host = new CalculateThousandDaysClient();

            System.Console.WriteLine("Skriv in vilket år du föddes: ");
            var year = System.Console.ReadLine();

            System.Console.WriteLine("Skriv in vilken månad du föddes i: ");
            var month = System.Console.ReadLine();

            System.Console.WriteLine("Skriv in vilken dag du föddes på: ");
            var day = System.Console.ReadLine();

            if (year != null && month != null && day != null)
            {
                var birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                System.Console.WriteLine(host.CalculateThousandDays(birthday));
            }
            System.Console.ReadLine();
        }
    }
}
