using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrdersApp.Domain.Models;

namespace OrdersApp.Repository
{
    public class ApplicationDbContext : IdentityDbContext<OrdersAppUser>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Ticket> Tickets{ get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
