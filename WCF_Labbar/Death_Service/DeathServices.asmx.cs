using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Death_Service
{
    /// <summary>
    /// Summary description for DeathServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeathServices : System.Web.Services.WebService
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

            for (var i = 0; i < deathOfJanuary.Length; i++)
            {
                if (deathOfJanuary[i].Contains(inputVal))
                {
                    var array = deathOfJanuary[i].Split(' ');
                    return inputVal + " " + array[0] + " " + array[1] + " " + array[2];
                }
            }
            return string.Empty;
        }
    }
}
