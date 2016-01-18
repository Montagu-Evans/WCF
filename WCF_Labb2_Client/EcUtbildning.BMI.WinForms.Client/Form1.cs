using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcUtbildning.BMI.WinForms.Client
{
    public partial class Form1 : Form
    {
        private CalculateBmiClient host;
        public Form1()
        {
            InitializeComponent();
            host = new CalculateBmiClient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    host = new CalculateBmiClient();
                }
                
                var weight = int.Parse(txtBoxWeight.Text);
                var length = double.Parse(txtBoxLength.Text);
                lblMessage.Text = host.CalculateBmi(weight, length);
            }
            catch (CommunicationException ex)
            {
                lblMessage.Text = $"Error please try again. {ex.Message}";
                throw;
            }
        }
    }
}
