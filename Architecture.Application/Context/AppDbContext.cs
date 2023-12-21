using Microsoft.EntityFrameworkCore;

namespace Architecture.Application.Context;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Domain.Entities.Beach> Beaches { get; set; }
    public async Task<int> SaveToDbAsync()
    {
        return await SaveChangesAsync();  
    }
}
