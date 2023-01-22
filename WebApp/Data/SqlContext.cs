using Microsoft.EntityFrameworkCore;
using WebApp.Entities;

namespace WebApp.Data
{
    // Här görs det också bara en sak typ.
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public SqlContext() { }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    }
}
