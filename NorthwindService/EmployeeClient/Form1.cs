using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClient.EmployeeService;

namespace EmployeeClient
{
    public partial class Form1 : Form
    {
        private EmployeeServiceClient host;
        public Form1()
        {
            InitializeComponent();
            host = new EmployeeServiceClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == CommunicationState.Faulted)
                {
                    host = new EmployeeServiceClient();
                }

                var getEmployee = host.GetEmployees(int.Parse(txtBoxForEmpId.Text));
                txtBox_First.Text = getEmployee.FirstName;
                txtBox_Last.Text = getEmployee.LastName;
                txtBox_Country.Text = getEmployee.Country;
                txtBox_Title.Text = getEmployee.Title;
            }
            catch (FaultException<SqlException> ex)
            {
                MessageBox.Show(ex.Detail.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (host.State == CommunicationState.Faulted)
                {
                    host = new EmployeeServiceClient();
                }

                var saveEmployee = new Employee()
                {
                    EmployeeId = int.Parse(txtBoxForEmpId.Text),
                    FirstName = txtBox_First.Text,
                    LastName = txtBox_Last.Text,
                    Country = txtBox_Country.Text,
                    Title = txtBox_Title.Text
                };

                host.SaveEmployee(saveEmployee);
            }
            catch (FaultException<SqlException> ex)
            {
                MessageBox.Show(ex.Detail.Message);
            }
        }
    }
}
