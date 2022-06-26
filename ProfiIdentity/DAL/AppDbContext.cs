using Microsoft.EntityFrameworkCore;
using profi.Models;

namespace ProfiFrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Testimonials> Testimonials { get; set; }
    }
}
