using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.ThousandDays
{
    [ServiceContract(Namespace = "http://EcUtbildning.ThousandDays")]

    public interface ICalculateThousandDays
    {
        [OperationContract]
        string CalculateThousandDays(DateTime date);
    }

    public class CalculateThousandDaysService : ICalculateThousandDays
    {
        public string CalculateThousandDays(DateTime date)
        {
            var timeSpan = DateTime.Now - date;
            var modulo = timeSpan.Days % 1000;
            var result = 1000 - modulo;
            var thousandDays = DateTime.Now.AddDays(result);
            return $"När du fyller jämnt antal 1000 dagar: {thousandDays.ToShortDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/EcUtbildning.ThousandDays");
            ServiceHost selfServiceHost = new ServiceHost(typeof(CalculateThousandDaysService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof(ICalculateThousandDays),
                    new WSHttpBinding(),
                    "CalculateThousandDaysService");

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
                Console.WriteLine($"Exception kastad. {ex.Message}");
                Console.ReadLine();
                throw;
            }
        }
    }
}
