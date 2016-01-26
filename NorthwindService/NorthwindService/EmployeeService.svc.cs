using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
        public Employee GetEmployees(int id)
        {
            var queryString = "SELECT * FROM Employees WHERE EmployeeID =" + id;
            var employee = new Employee();

            using (SqlConnection connection =
            new SqlConnection(_connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.EmployeeId = int.Parse(reader["EmployeeID"].ToString());
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.Country = reader["Country"].ToString();
                    employee.Title = reader["Title"].ToString();
                }
            }

            return employee;
        }

        public void SaveEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Employees SET FirstName = @firstName, LastName = @lastName, Country = @country, Title = @title where EmployeeID = @employeeId ";
                    cmd.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@country", employee.Country);
                    cmd.Parameters.AddWithValue("@title", employee.Title);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
