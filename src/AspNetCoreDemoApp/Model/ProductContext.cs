using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetCoreDemoApp.Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext( DbContextOptions<ProductContext> options ) :
            base(options)
        {
        }
    }
}
