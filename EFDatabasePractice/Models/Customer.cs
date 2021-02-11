using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//Renamed from customerID in schema
        [StringLength(4000)]
        public string CompanyName { get; set; }
        [StringLength(4000)]
        public string Name { get; set; }//Renamed from contactName in schema
        [StringLength(4000)]
        public string ContactTitle { get; set; }
        [StringLength(4000)]
        [EmailAddress]
        public string Address { get; set; }
        [StringLength(4000)]
        public string City { get; set; }
        public int RegionID { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        [StringLength(4000)]
        public string PostalCode { get; set; }
        [StringLength(4000)]
        public string Country { get; set; }
        [Phone]
        [StringLength(4000)]
        public string Phone { get; set; }
        public int Fax { get; set; }
    }
}
