using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;


namespace RazorPagesDemo.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext? _dbContext;
        public Category? Category { get; set; }
        public DeleteModel(AppDbContext context)
        {
            _dbContext = context;
        }
        public void OnGet(int id)
        {
            Category = _dbContext.Categories.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            Category category = _dbContext.Categories.Find(Category.Id);
            string name = category.Name;
            if(category != null)
            {
                _dbContext.Remove(category);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = name + " Deleted Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
