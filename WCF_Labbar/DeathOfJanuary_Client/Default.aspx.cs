using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DeathOfJanuary_Client.DeathOfJanuaryServiceReference;

namespace DeathOfJanuary_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            DeathOfJanuaryServiceReference.DeathOfJanuaryServiceSoapClient client = new DeathOfJanuaryServiceSoapClient();

            var death = client.DeathOfJanuary(txtBoxOfDeath.Text);
            if (death != string.Empty)
            {
                lbl_result.Text = death;
            }
            else
            {
                lbl_result.Text = "Woops, try another number";
            }
        }
    }
}