using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [StringLength(4000)]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
        public int QuantityPerLabel { get; set; }
        public decimal UnitPrice { get; set; }
        [Display(Name = "Quantity")]
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        [StringLength(4000)]
        public string ReorderLevel { get; set; }
        [StringLength(4000)]
        public string Discontinued { get; set; }

    }
}
