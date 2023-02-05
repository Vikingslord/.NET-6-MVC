using BookStore.WebAppMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.WebAppMVC.Data
{
    public class CategoryDataContext : DbContext 
    {
        public CategoryDataContext(DbContextOptions<CategoryDataContext> options) : base(options)
        {

        }

        //passing in Category model
        public DbSet<Category> Category { get; set; }
    }
}
