using Microsoft.EntityFrameworkCore;

namespace TodoApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    // Notice: No DbSet properties are defined here.
}
