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

        //[WebMethod]
        //public string FastestRecord(string inputVal)
        //{
        //    var file = File.ReadAllLines(Server.MapPath("Hastighetsrekord.txt"));

        //    for (int i = 0; i < file.Length; i++)
        //    {
        //        var array = file[i].Split('-');

        //        for (int j = 0; j < array.Length; j++)
        //        {
        //            if(array.Any(x=>x.Replace("-", "") == inputVal))
        //            return array[0] + " " + array[1] + " " + array[2];
        //        }
        //    }
        //    return string.Empty;
        //}

        [WebMethod]
        public string DeathCasesJanuary(string inputVal)
        {
            var file = File.ReadAllLines(Server.MapPath("Dödsfall.txt"));

            foreach (var item in file)
            {
                var array = item.Split(' ');

                if (array.Any(x => x.Replace(",", "") == inputVal))
                {
                    return array[2] + " " + array[3] + " " + array[4];
                }
            }
            return string.Empty;
        }
    }
}
