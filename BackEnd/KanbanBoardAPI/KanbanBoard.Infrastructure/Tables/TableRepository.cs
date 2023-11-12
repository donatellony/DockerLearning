using KanbanBoard.Application.Common.Interfaces;
using KanbanBoard.Domain.Tables;
using KanbanBoard.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;

namespace KanbanBoard.Infrastructure.Tables;

public class TableRepository : ITableRepository
{
    private readonly KanbanBoardDbContext _dbContext;

    public TableRepository(KanbanBoardDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Table?> GetAsync(ObjectId id)
    {
        var query = _dbContext.Tables.Where(tab => tab.Id == id);
        return await query.FirstOrDefaultAsync();
    }

    public async Task UpdateAsync()
    {
        //TODO create
        await Task.CompletedTask;
    }
}