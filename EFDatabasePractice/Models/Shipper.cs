using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Shipper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipperID { get; set; }
        [Display(Name = "Shipper Company Name")]
        [StringLength(4000)]
        public string CompanyName { get; set; }
        [Display(Name = "Shipper PhoneNumber")]
        [Phone]
        [StringLength(4000)]
        public string Phone { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
