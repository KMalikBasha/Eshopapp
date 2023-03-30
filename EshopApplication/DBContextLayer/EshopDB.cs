using EshopApplication.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EshopApplication.DBContextLayer
{
    public class EshopDB:DbContext
    {
        public EshopDB(DbContextOptions<EshopDB>options):base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<OrderedItems> OrderedItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Response> Response { get; set; }
        public DbSet<LoginUser> loginuser { get; set; }

    }
}
