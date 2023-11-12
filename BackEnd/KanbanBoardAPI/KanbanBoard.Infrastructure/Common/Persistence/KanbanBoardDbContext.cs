using System.Reflection;
using KanbanBoard.Application.Common.Interfaces;
using KanbanBoard.Domain.Boards;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace KanbanBoard.Infrastructure.Common.Persistence;

public class KanbanBoardDbContext : DbContext, IUnitOfWork
{
    public DbSet<Table> Tables { get; set; } = null!;

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
        modelBuilder.Entity<Table>().ToCollection("Table");
    }
}