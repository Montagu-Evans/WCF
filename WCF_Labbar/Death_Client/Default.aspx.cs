using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Death_Client.DeathServiceReference;

namespace Death_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            DeathServiceReference.DeathServicesSoapClient client = new DeathServicesSoapClient();
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