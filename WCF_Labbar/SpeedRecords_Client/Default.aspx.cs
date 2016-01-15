using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpeedRecords_Client.SpeedRecordsServiceReference;

namespace SpeedRecords_Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            SpeedRecordsServiceReference.SpeedRecordsServiceSoapClient client = new SpeedRecordsServiceSoapClient();
            var speedRecord = client.SpeedRecord(txtBox_speed.Text);

            if (speedRecord != string.Empty)
            {
                lbl_result.Text = speedRecord;
            }
            else
            {
                lbl_result.Text = "Nope, please try another date";
            }
        }
    }
}