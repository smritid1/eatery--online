using Microsoft.EntityFrameworkCore;
using eateryonline.Models;


namespace eateryonline.Models
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FoodItem> FoodItems { get; set; }
    }
}

