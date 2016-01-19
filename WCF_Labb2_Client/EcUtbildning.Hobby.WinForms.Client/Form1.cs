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

namespace EcUtbildning.Hobby.WinForms.Client
{
    public partial class Form1 : Form
    {
        private MyHobbyClient host;
        public Form1()
        {
            InitializeComponent();
            host = new MyHobbyClient();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            if (host.State == CommunicationState.Faulted)
            {
                host = new MyHobbyClient();
            }

            lblResult.Text = host.MyHobby(txtBox.Text);
        }
    }
}
