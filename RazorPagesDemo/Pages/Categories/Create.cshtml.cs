using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category? Category { get; set; }
        public void OnGet()
        {
        }
    }
}
