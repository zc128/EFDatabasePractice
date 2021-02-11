using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFDatabasePractice.Pages.Admin.Category
{
    public class CategoryCreateModel : PageModel
    {
        private readonly EFDatabasePractice.Context.EcommerceShopContext _ctx;

        [FromForm]
        public EFDatabasePractice.Models.Category Category { get; set; }
        public CategoryCreateModel(EFDatabasePractice.Context.EcommerceShopContext ctx)
        {
            _ctx = ctx;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _ctx.Add(Category);
            _ctx.SaveChanges();

        }
    }
}
