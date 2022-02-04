using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;


namespace RazorPagesDemo.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly AppDbContext? _dbContext;
        public Category? Category { get; set; }
        public EditModel(AppDbContext context)
        {
            _dbContext = context;
        }
        public void OnGet(int id)
        {
            Category = _dbContext.Categories.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "Category Name and Display Order must not be the same.");
            }
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Update(Category);
                await _dbContext.SaveChangesAsync();
                TempData["success"] = Category.Name + " Updated Successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
