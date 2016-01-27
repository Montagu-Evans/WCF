using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;

namespace NorthwindService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class EmployeeService : IEmployeeService
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
        public Employee GetEmployees(int id)
        {
            try
            {
                var queryString = "SELECT * FROM Employees WHERE EmployeeID =" + id;
                var employee = new Employee();

                using (SqlConnection connection =
                new SqlConnection(_connectionString))
                {
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
            catch (FaultException<SqlException> ex)
            {
                throw new FaultException<SqlException>(ex.Detail);
            }

            catch (FaultException ex)
            {
                throw new FaultException(ex.Message);
            }

        }

        public void SaveEmployee(Employee employee)
        {
            try
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

            catch (FaultException<SqlException> ex)
            {
                throw new FaultException<SqlException>(ex.Detail);
            }

            catch (FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
