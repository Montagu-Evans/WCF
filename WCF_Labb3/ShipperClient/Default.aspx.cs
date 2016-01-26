using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShipperClient.NwService;

namespace ShipperClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_GetShipper_Click(object sender, EventArgs e)
        {
            var client = new ShipperServiceClient();
            var host = client.GetShipperId(int.Parse(txtBoxOne.Text));
            TxtBoxTwo.Text = host.ShipperId.ToString();
            txtBoxThree.Text = host.CompanyName;
            txtBoxFour.Text = host.Phone;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var client = new ShipperServiceClient();
            var shipper = new Shipper();

            shipper.ShipperId = int.Parse(TxtBoxTwo.Text);
            shipper.CompanyName = txtBoxThree.Text;
            shipper.Phone = txtBoxFour.Text;

            client.SaveShipper(shipper);
        }
    }
}