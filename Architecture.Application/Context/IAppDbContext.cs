using Microsoft.EntityFrameworkCore;

namespace Architecture.Application.Context;

public interface IAppDbContext
{
    DbSet<Domain.Entities.Beach> Beaches { get; }
    Task<int> SaveToDbAsync();
}
