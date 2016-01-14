using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                var array = deathOfJanuary[i].Split(' ');

                for (var j = 0; j < array.Length; j++)
                {
                    if (array[j].Replace(",", "") == inputVal)
                    {
                        return "<strong>" + inputVal + " " + array[j + 1] + " " + array[j + 2] + " " + array[j + 3] + " " + array[j + 4] + " " + array[j + 5] + " " + array[j + 6] + " " + array[j + 7] + "</strong>";
                    }
                }
            }
            return "Finns ingen vid detta namn";

            //foreach (var item in deathOfJanuary)
            //{
            //    var array = item.Split(' ');

            //    if (array.Any(x => x.Replace(",", "") == inputVal))
            //    {
            //        return "<strong>" + inputVal + " " + array[3] + " " + array[4] + " " + array[5] + " " + array[6] + " " + array[7] + " " + array[8] + " " + array[9] + "</strong>";
            //    }
            //}
            //return string.Empty;
        }
    }
}
