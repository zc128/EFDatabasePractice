using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFDatabasePractice.Models;

namespace EFDatabasePractice.Pages
{
    public class ProductModel : PageModel
    {
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;
        public Product SelectedProduct { get; set; }
        public ProductModel(EFDatabasePractice.Context.EcommerceShopContext ctx)
        {

            _ctx = ctx;
        }
        

        public void OnGet(string ProductID)
        {
         
           ViewData["Categories"] = _ctx.Categories.Take(10).ToList();
           ViewData["Suppliers"] = _ctx.Suppliers.Take(10).ToList();
           ViewData["Shippers"] = _ctx.Shippers.Take(10).ToList();

            if (String.IsNullOrEmpty(ProductID))
            {
                Response.Redirect("/");
                return;
            }

            SelectedProduct = _ctx.Products.Where(p => p.ProductID == Int32.Parse(ProductID)).FirstOrDefault();

            if (SelectedProduct == null)
            {
                Response.Redirect("/Error");
                return;
            }
        }
    }
}
