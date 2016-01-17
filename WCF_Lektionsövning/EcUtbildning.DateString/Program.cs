using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.DateString
{
    [ServiceContract(Namespace = "http://EcUtbildning.DateString")]


    public interface IDateAsString
    {
        [OperationContract]
        string ReturnDateAsString(string inputVal);
    }

    public class DateAsStringService : IDateAsString
    {
        public string ReturnDateAsString(string inputVal)
        {
            Console.WriteLine($"Mottaget, {inputVal}");
            if (inputVal == "2016")
            {
                return inputVal;
            }
            return "This is not correct. Please correct error";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri  baseAddress = new Uri("http://localhost:8080/EcUtbildning.DateString");
            ServiceHost selfServiceHost = new ServiceHost(typeof(DateAsStringService), baseAddress);

            try
            {
                //Endpoint
                selfServiceHost.AddServiceEndpoint
                    (typeof (IDateAsString),
                        new WSHttpBinding(), 
                        "DateAsStringService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfServiceHost.Description.Behaviors.Add(smb);

                selfServiceHost.Open();

                Console.WriteLine($"Servicen är nu öppen ! {baseAddress}");
                Console.WriteLine("Tryck ENTER för att avsluta.");

                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine($"Ett kommunikationsfel har inträffat!, {ex.Message}"); //Nya string.format C# 6.0!

                //Om ett fel innträffar kommer vi att stänga tjänsten
                selfServiceHost.Abort();
                //selfServiceHost.Close(); //Delay på close
                Console.ReadLine();
            }
        }
    }
}
