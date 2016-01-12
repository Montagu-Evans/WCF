using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb1_WeatherService
{
    /// <summary>
    /// Summary description for WeatherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string WeatherServices()
        {
            Random rnd = new Random();

            var stringVector = new string[]{"Solen skiner", "Molnigt", "Regn", "Snö"};
            var randomNumber = rnd.Next(0, 4);

            return stringVector[randomNumber];
        }
    }
}
