using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Test.Models
{
    public class Contact
    {
        public int id { get; set; }
        [Column(TypeName = "bigint")]
        public Int64 EmployeeId { get; set; }
        public byte MobileCountryCode { get; set; }
        public Int64 Mobile { get; set; }
        public byte AlternateMobileCountryCode { get; set; }
        public Int64 AlternateMobile { get; set; }
        public byte WorkNumberCountryCode { get; set; }
        public Int64 WorkNumber { get; set; }
        public byte WorkExtension { get; set; }
        public byte HomeCountryCode { get; set; }
        public Int64 HomeNumber { get; set; }
        public byte HomeExtension { get; set; }
        public byte CompanyMobileCountryCode { get; set; }
        public Int64 CompanyMobile { get; set; }
        public bool Active { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64 ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
