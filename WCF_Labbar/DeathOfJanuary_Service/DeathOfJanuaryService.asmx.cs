using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DeathOfJanuary_Service
{
    /// <summary>
    /// Summary description for DeathOfJanuaryService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeathOfJanuaryService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string DeathOfJanuary(string inputVal)
        {
            var file = File.ReadAllLines(Server.MapPath("Dödsfall.txt"));

            for (int i = 0; i < file.Length; i++)
            {
                var array = file[i].Split('-');

                for (int j = 0; j < array.Length; j++)
                {   
                    if (array[j].Replace("-", ",") == inputVal)
                    {
                        return $"Names of the people who died on this day: {array[0] + " " + array[1] + ": " + array[2]}";
                    }
                }
            }
            return "Woops, try another date";
        }
    }
}
