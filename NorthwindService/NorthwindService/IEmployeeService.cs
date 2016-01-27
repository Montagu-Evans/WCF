using System;
using System.Data.SqlClient;
using System.ServiceModel;

namespace NorthwindService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        Employee GetEmployees(int id);

        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        void SaveEmployee(Employee employee);
    }
}