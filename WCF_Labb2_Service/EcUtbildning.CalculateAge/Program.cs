using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace EcUtbildning.CalculateAge
{
    [ServiceContract(Namespace = "http://EcUtbildning.CalculateAge")]

    public interface ICalculateAge
    {
        [OperationContract]
        string CalculateAge(DateTime birthday);
    }

    public class CalculateAgeService : ICalculateAge
    {
        public string CalculateAge(DateTime birthday)
        {
            //Console.WriteLine($"Received: {birthday}");
            var timeSpan = DateTime.Now - birthday;
            return timeSpan.Days.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/EcUtbildning.CalculateAge");
            ServiceHost selfServiceHost = new ServiceHost(typeof(CalculateAgeService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof (ICalculateAge),
                        new WSHttpBinding(),
                        "CalculateAgeService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfServiceHost.Description.Behaviors.Add(smb);
                selfServiceHost.Open();

                Console.WriteLine($"Servicen är öppen på {baseAddress}");
                Console.WriteLine("Tryck ENTER för att avsluta");

                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                selfServiceHost.Abort();
                Console.WriteLine($"Terminate {ex.Message}");
                Console.ReadLine();
                throw;
            }
        }
    }
}
