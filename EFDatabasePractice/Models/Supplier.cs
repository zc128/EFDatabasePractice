using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        [StringLength(4000)]
        public string CompanyName { get; set; }
        [StringLength(4000)]
        public string ContactName { get; set; }
        [StringLength(4000)]
        public string ContactTitle { get; set; }
        [Display(Name = "Supplier Company Address")]
        [StringLength(4000)]
        public string Address { get; set; }
        [StringLength(4000)]
        public string City { get; set; }
        [StringLength(4000)]
        public string Region { get; set; }
        [StringLength(4000)]
        public string PostalCode { get; set; }
        [StringLength(4000)]
        public string Country { get; set; }
        [Display(Name = "Supplier PhoneNumber")]
        [Phone]
        [StringLength(4000)]
        public string Phone { get; set; }
        public int Fax { get; set; }
        [Display(Name = "Supplier HomePage URL")]
        [Url(ErrorMessage = "Please use a valid URL")]
        [StringLength(4000)]
        public string HomePage { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
