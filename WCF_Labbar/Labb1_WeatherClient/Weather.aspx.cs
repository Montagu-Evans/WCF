using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Labb1_WeatherClient.Service_References.ServiceForCheckingWeather;

namespace Labb1_WeatherClient
{
    public partial class Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_showWeather_Click(object sender, EventArgs e)
        {
            WeatherServiceSoapClient client = new WeatherServiceSoapClient();
            labelResult.Text = client.WeatherServices();
        }
    }
}