using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SubtractTwoNumbers_Client.Service_References.SubtractTwoNumbers_ServiceReference;

namespace SubtractTwoNumbers_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_showResult_Click(object sender, EventArgs e)
        {
            SubtractTwoNumbersSoapClient client = new SubtractTwoNumbersSoapClient();
            lbl_result.Text = client.SubtractNumbers(int.Parse(txtBoxOne.Text), int.Parse(txtBoxTwo.Text)).ToString();
        }
    }
}