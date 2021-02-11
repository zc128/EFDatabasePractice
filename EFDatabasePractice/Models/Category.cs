using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabasePractice.Models
{
    public class Category
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//Renamed from categoryID in schema
        [Display(Name = "Category Name")]
        [StringLength(4000)]
        public string Name { get; set; }//Renamed from categoryName in schema
        [Display(Name = "Category Description")]
        [StringLength(4000)]
        public string Description { get; set; }
        [Display(Name = "Category Picture URL")]
        [Url(ErrorMessage = "Please use a valid URL")]
        [StringLength(4000)]
        public string Picture { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
