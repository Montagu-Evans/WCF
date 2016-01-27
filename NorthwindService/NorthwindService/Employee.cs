using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NorthwindService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        [Required(ErrorMessage = "Only digits")] 
        public int EmployeeId { get; set; }

        [DataMember]
        [Required]
        [MinLength(2, ErrorMessage = "Type more than 2 characters")]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [MinLength(2, ErrorMessage = "Type more than 2 characters")]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        public string Country { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }
    }
}