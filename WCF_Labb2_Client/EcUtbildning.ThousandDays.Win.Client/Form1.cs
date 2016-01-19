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

namespace EcUtbildning.ThousandDays.Win.Client
{
    public partial class Form1 : Form
    {
        private CalculateThousandDaysClient host;
        public Form1()
        {
            InitializeComponent();
            host = new CalculateThousandDaysClient();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    host = new CalculateThousandDaysClient();
                }

                var dateUntilThousandDays = new DateTime(int.Parse(txtBoxYear.Text), int.Parse(txtBoxMonth.Text), int.Parse(txtBoxDay.Text));
                lblMessage.Text = host.CalculateThousandDays(dateUntilThousandDays);
            }
            catch (CommunicationException ex)
            {
                lblMessage.Text = $"Error please try again. {ex.Message}";
                throw;
            }
        }
    }
}
