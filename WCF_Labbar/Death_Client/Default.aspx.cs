﻿using System;
using TwoToTen_Client.Service_References.TwoToTenServiceReferences;

namespace TwoToTen_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            TwoToTenServiceReferences.client = new DeathServicesSoapClient();
            var death = client.DeathCasesJanuary(txtBox.Text);
            if (death != string.Empty)
            {
                lbl_result.Text = death; 
            }
            else
            {
                lbl_result.Text = "test";
            }
            
        }
    }
}