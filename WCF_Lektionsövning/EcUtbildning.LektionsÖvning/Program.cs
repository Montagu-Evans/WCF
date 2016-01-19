using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace EcUtbildning.DateString
{
    [ServiceContract(Namespace = "http://EcUtbildning.LektionsÖvning")]

    public interface IDateFormat
    {
        [OperationContract]
        string DateAsString(string inputVal);
    }

    public class DateFormatService : IDateFormat
    {
        public string DateAsString(string inputVal)
        {
            return inputVal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
