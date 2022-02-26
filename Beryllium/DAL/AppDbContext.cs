using Beryllium.Models;
using Microsoft.EntityFrameworkCore;

namespace Beryllium.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
