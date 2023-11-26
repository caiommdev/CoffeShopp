using Microsoft.EntityFrameworkCore;
using WebApp.Models.Coffe;

namespace WebApp.Data
{
    public class OrderContex : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderContex(DbContextOptions<OrderContex> options) : base(options)
        {

        }
    }
}
