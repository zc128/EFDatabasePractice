using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFDatabasePractice.Pages.Admin.Supplier
{
    public class SupplierCreateModel : PageModel
    {
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;

        [FromForm]
        public EFDatabasePractice.Models.Supplier Supplier { get; set; }
        public SupplierCreateModel(EFDatabasePractice.Context.EcommerceShopContext ctx)
        {
            _ctx = ctx;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _ctx.Add(Supplier);
            _ctx.SaveChanges();

        }
    }
}
