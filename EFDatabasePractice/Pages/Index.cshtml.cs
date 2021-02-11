using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDatabasePractice.Models;

namespace EFDatabasePractice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;

        public IndexModel(ILogger<IndexModel> logger, EFDatabasePractice.Context.EcommerceShopContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public void OnGet()
        {
            ViewData["ProdQuantity"] = _ctx.Products.Count();
            ViewData["ProdList"] = _ctx.Products.Take(10).ToList();
            ViewData["Categories"] = _ctx.Categories.Take(10).ToList();
             
        }
    }
}
