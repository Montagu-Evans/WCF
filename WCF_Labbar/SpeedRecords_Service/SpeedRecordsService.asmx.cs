using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SpeedRecords_Service
{
    /// <summary>
    /// Summary description for SpeedRecordsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SpeedRecordsService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string SpeedRecord(string inputVal)
        {
            var file = File.ReadAllLines(Server.MapPath("SpeedRecords.txt"));
            for (int i = 0; i < file.Length; i++)
            {
                var array = file[i].Split('-');

                for (int j = 0; j < array.Length; j++)
                {
                    if(array[j].Replace("-", "") == inputVal)
                    return $"Speed records on this day: {array[0] + " " + array[1] + " " + array[2]}";
                }
            }
            return "Woops! Something went wrong. Please try again";
        }
    }
}
