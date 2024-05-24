using AngularCrudWebapi.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace AngularCrudWebapi.Model.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<BlogPost> tblBlogPosts { get; set; }
        public DbSet<Category> tblCategories { get; set; }
    }
}
