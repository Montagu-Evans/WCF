using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace EcUtbildning.CalculateBMI
{
    [ServiceContract(Namespace = "http://EcUtbildning.CalculateBmi")]

    public interface ICalculateBmi
    {
        [OperationContract]
        string CalculateBmi(int weight, double length);
    }

    public class CalculateBmiService : ICalculateBmi
    {
        public string CalculateBmi(int weight, double length)
        {
            Console.WriteLine("Calculate your BMI!");
 
            Console.WriteLine($"Received: {weight}");
            Console.WriteLine($"Received: {length}");
            var result = weight / (length * length);
            Console.WriteLine($"Received: {result}");

            return $"Your BMI is: {result}";
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/EcUtbildning.CalculateBmi");
            ServiceHost selfServiceHost = new ServiceHost(typeof(CalculateBmiService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof (ICalculateBmi),
                        new WSHttpBinding(),
                        "CalculateBmiService");

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
                Console.WriteLine($"Oops. Something went terribly wrong! {ex.Message}");
                selfServiceHost.Abort();
                Console.ReadLine();
                throw;
            }
        }
    }
}
