using Microsoft.EntityFrameworkCore;
using RecipeBox.Models;

namespace RecipeBox.Data
{
    public class RecipeBoxContext : DbContext
    {
        public RecipeBoxContext (DbContextOptions<RecipeBoxContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
    }
}