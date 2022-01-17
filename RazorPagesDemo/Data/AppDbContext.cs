using Microsoft.EntityFrameworkCore;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }
        DbSet<Category>? Categories { get; set; }
    }
}
