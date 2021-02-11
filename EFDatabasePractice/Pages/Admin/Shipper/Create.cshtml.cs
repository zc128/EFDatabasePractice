using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFDatabasePractice.Pages.Admin.Shipper
{
    public class ShipperCreateModel : PageModel
    {
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;

        [FromForm]
        public EFDatabasePractice.Models.Shipper Shipper { get; set; }
        public ShipperCreateModel(EFDatabasePractice.Context.EcommerceShopContext ctx)
        {
            _ctx = ctx;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _ctx.Add(Shipper);
            _ctx.SaveChanges();

        }
    }
}
