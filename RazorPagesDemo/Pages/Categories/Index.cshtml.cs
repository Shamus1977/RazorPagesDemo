using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext? _dbContext;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(AppDbContext context)
        {
            _dbContext = context;
        }
        public void OnGet()
        {
            Categories = _dbContext.Categories;
        }
    }
}
