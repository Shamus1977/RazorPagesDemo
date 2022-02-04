using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;


namespace RazorPagesDemo.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly AppDbContext? _dbContext;
        public Category? Category { get; set; }
        public CreateModel(AppDbContext context)
        {
            _dbContext = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "Category Name and Display Order must not be the same.");
            }
            if (ModelState.IsValid)
            {
                await _dbContext.Categories.AddAsync(Category);
                await _dbContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
