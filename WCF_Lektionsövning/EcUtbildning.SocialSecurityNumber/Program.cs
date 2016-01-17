using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace EcUtbildning.SocialSecurityNumber
{
    [ServiceContract(Namespace = "http://EcUtbildning.SocialSecurityNumber")]

    public interface IGetSocialSecurityNumber
    {
        [OperationContract]
        string GetSocialSecurityNumber(string inputVal);
    }

    public class GetSocialSecurityNumberService : IGetSocialSecurityNumber
    {
        public string GetSocialSecurityNumber(string inputVal)
        {
            Console.WriteLine($"Mottaget: {inputVal}");
            if (inputVal.EndsWith("1") ||
                inputVal.EndsWith("3") ||
                inputVal.EndsWith("5") ||
                inputVal.EndsWith("7") ||
                inputVal.EndsWith("9"))
            {
                return $"{inputVal} belongs to a woman";
            }

            return $"{inputVal} belongs to a man";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/EcUtbildning.SocialSecurityNumber");
            ServiceHost selfsServiceHost = new ServiceHost(typeof(GetSocialSecurityNumberService), baseAddress);

            try
            {
                selfsServiceHost.AddServiceEndpoint
                    (typeof (IGetSocialSecurityNumber),
                        new WSHttpBinding(),
                        "GetSocialSecurityNumberService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfsServiceHost.Description.Behaviors.Add(smb);
                selfsServiceHost.Open();

                Console.WriteLine($"Servicen är nu öppen på: {baseAddress}");
                Console.WriteLine("Tryck ENTER för att avsluta");

                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine($"Ett kommunikationsfel har inträffat!, {ex.Message}");
                selfsServiceHost.Abort();
                Console.ReadLine();
                throw;
            }
        }
    }
}
