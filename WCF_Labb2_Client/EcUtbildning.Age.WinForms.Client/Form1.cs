using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace EcUtbildning.Age.WinForms.Client
{
    public partial class Form1 : Form
    {
        private CalculateAgeClient host;
        public Form1()
        {
            InitializeComponent();
            host = new CalculateAgeClient();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == System.ServiceModel.CommunicationState.Faulted)
                {
                    host = new CalculateAgeClient();
                }

                var dateOfBirth = new DateTime(int.Parse(txtBoxYear.Text), int.Parse(txtBoxMonth.Text), int.Parse(txtBoxDay.Text));
                lblMessage.Text = host.CalculateAge(dateOfBirth);
            }
            catch (CommunicationException ex)
            {
                lblMessage.Text = $"Error please try again. {ex.Message}";
                throw;
            }
        }
    }
}
