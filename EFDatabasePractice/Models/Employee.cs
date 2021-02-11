using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [StringLength(4000)]
        public string LastName { get; set; }
        [StringLength(4000)]
        public string FirstName { get; set; }
        [StringLength(4000)]
        public string Title { get; set; }
        [StringLength(4000)]
        public string TitleOfCourtesy { get; set; }
    /*    public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }*/
        [EmailAddress]
        [StringLength(4000)]
        public string Address { get; set; }
        [StringLength(4000)]
        public string City { get; set; }   
        public int? RegionID { get; set; }
        [ForeignKey("RegionID")]
        public Region Region { get; set; }
        [StringLength(4000)]
        public string PostalCode { get; set; }
        [StringLength(4000)]
        public string Country { get; set; }
        [Phone]
        [StringLength(4000)]
        public string HomePhone { get; set; }
        [StringLength(4000)]
        public string Extension { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        [StringLength(4000)]
        public string Photo { get; set; }
        [StringLength(4000)]
        public string Notes { get; set; }
        [StringLength(4000)]
        public string ReportsTo { get; set; }
        [Url(ErrorMessage = "Please use a valid URL")]
        [StringLength(4000)]
        public string PhotoPath { get; set; }
        public ICollection<Territory> Territories { get; set; }

    }
}
