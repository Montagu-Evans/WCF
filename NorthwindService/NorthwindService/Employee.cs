using System.Runtime.Serialization;

namespace NorthwindService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}