﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using GetNameDay_Client.Service_References.GetNameDayServiceReference;

namespace GetNameDay_Client
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_result_Click(object sender, EventArgs e)
        {

            GetNameDaySoapClient client = new GetNameDaySoapClient();
            var birthday = client.GetNameAndGetTheDate(txtBox.Text);
            lbl_result.Text = birthday != string.Empty ? birthday : "skriv in ett namn!";
            
        }
    }
}