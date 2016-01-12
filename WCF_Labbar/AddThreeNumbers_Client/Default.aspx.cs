using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AddThreeNumbers_Client.AddThreeNumbers_ServiceReference;

namespace AddThreeNumbers_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_result_Click(object sender, EventArgs e)
        {
            AddThreeNumbers_ServiceReference.AddThreeNumbersSoapClient client = new AddThreeNumbersSoapClient();
            lbl_result.Text = client.AddTotalThreeNumbers(int.Parse(txtBoxOne.Text), int.Parse(txtBoxTwo.Text), int.Parse(txtBoxThree.Text)).ToString();
        }
    }
}