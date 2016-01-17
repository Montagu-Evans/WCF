using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private GetSocialSecurityNumberClient host;
        public Form1()
        {
            InitializeComponent();
            host = new GetSocialSecurityNumberClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_message.Text = host.GetSocialSecurityNumber(txtBox.Text);
        }
    }
}
