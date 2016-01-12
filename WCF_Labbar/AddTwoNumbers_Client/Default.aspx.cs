using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AddTwoNumbers_Client.AddTwoNumbers_ServiceReference;

namespace AddTwoNumbers_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_result_Click(object sender, EventArgs e)
        {
            AddTwoNumbers_ServiceReference.AddNumbersSoapClient client = new AddNumbersSoapClient();
            var tal1 = int.Parse(txtBoxOne.Text);
            var tal2 = int.Parse(txtBoxTwo.Text);
            lbl_result.Text = client.AddTwoNumbers(tal1, tal2).ToString();
        }
    }
}