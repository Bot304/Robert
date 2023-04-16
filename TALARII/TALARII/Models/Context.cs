using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace TALARII.Models
{
    public class Context : DbContext
    {
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<ListModel> ListModels { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
