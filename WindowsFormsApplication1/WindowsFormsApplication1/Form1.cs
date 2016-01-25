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
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private ServiceReference1.Service1Client client;
        public Form1()
        {
            InitializeComponent();
            client = new Service1Client();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (client.State == CommunicationState.Faulted)
            {
                client = new Service1Client();
            }

            client = new Service1Client("NetTcpBinding_IService1");
            client.GetData(4);
        }
    }
}
