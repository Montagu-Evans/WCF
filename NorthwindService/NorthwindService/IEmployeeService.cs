using System;
using System.Data.SqlClient;
using System.ServiceModel;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
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