using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace EcUtbildning.Hobby
{
    [ServiceContract(Namespace = "http://EcUtbildning.Hobby")]

    public interface IMyHobby
    {
        [OperationContract]
        string MyHobby(string inputVal);
    }

    public class MyHobbyService : IMyHobby
    {
        public string MyHobby(string inputVal)
        {
            if (inputVal == "fifa" || inputVal == "Fifa" || inputVal == "FIFA")
            {
                return $"Errmahgeerrd, truly a great choice! There's nothing that beats {inputVal.ToUpper()}!!";
            }
            if (inputVal == "pes" || inputVal == "Pes" || inputVal == "PES")
            {
                return $"{inputVal.ToUpper()}!? I won't even comment on this bro...";
            }
            return "Please try again!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/EcUtbildning.Hobby");
            ServiceHost selfServiceHost = new ServiceHost(typeof(MyHobbyService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof (IMyHobby),
                        new WSHttpBinding(),
                        "MyServiceHobby");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfServiceHost.Description.Behaviors.Add(smb);
                selfServiceHost.Open();

                Console.WriteLine($"Servicen är nu öppen på {baseAddress}");
                Console.WriteLine("Tryck ENTER för att avsluta");

                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                selfServiceHost.Abort();
                Console.WriteLine($"Error, please see exception {ex.Message}");
                Console.ReadLine();
                throw;
            }
        }
    }
}
