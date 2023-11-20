using System.Reflection;
using KanbanBoard.Application.Common.Interfaces;
using KanbanBoard.Domain.Tables;
using Microsoft.EntityFrameworkCore;

namespace KanbanBoard.Infrastructure.Common.Persistence;

public class KanbanBoardDbContext : DbContext, IUnitOfWork
{
    public DbSet<Table> Tables => Set<Table>();

    public KanbanBoardDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public async Task CommitChangesAsync()
    {
        await SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}