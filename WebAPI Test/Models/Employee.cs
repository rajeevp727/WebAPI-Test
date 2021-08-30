using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Test.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Column(TypeName = "bigint")]
        public Int64 EmployeeId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime CertificateDOB { get; set; }
        public DateTime ActualDOB { get; set; }
        public DateTime DOJ { get; set; }
        public bool Gender { get; set; }
        public string ReportingManagerId { get; set; }
        public string OfficeLocation { get; set; }
        public bool Active { get; set; }
        public string CompanyEmailId { get; set; }
        public string PersonalEmailId { get; set; }
        public DateTime SeperatedDate { get; set; }
        public bool MaritalStatus { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64 ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
