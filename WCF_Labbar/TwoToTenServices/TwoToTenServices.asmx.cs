using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TwoToTenServices
{
    /// <summary>
    /// Summary description for TwoToTenServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TwoToTenServices : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string DeathCasesJanuary(string inputVal)
        {
            var deathOfJanuary = File.ReadAllLines(Server.MapPath("Dödsfall.txt"));

            foreach (var item in deathOfJanuary)
            {
                var array = item.Split(' ');

                if (array.Any(x => x.Replace(",", "") == inputVal))
                {
                    return "<strong>" + "Day of death: " + "</strong>" + array[0] + " " + array[1];
                }
            }
            return string.Empty;
        }
    }
}
