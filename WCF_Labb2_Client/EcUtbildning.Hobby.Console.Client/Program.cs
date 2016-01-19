using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.Hobby.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new MyHobbyClient();
            System.Console.WriteLine("My hobby is playing FIFA. Are you a FIFA or a PES fan?");
            var hobby = System.Console.ReadLine();
            System.Console.WriteLine(host.MyHobby(hobby));
            System.Console.ReadLine();
        }
    }
}
