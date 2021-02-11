using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFDatabasePractice.Pages.Admin.Product
{
    public class ProductCreateModel : PageModel
    {
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;

        [FromForm]
        public EFDatabasePractice.Models.Product Product { get; set; }
        public ProductCreateModel(EFDatabasePractice.Context.EcommerceShopContext ctx) 
        {
            _ctx = ctx;
        }
        
        public void OnGet()
        {
        }
        
        public void OnPost()
        {
            if (Product.CategoryID > 0 && Product.SupplierID >0)
            {
                _ctx.Add(Product);
                _ctx.SaveChanges();

            }

        }
    }
}
