using KanbanBoard.Domain.Tables;

namespace KanbanBoard.Application.Common.Interfaces;

//TODO change to use the UserId in the future.
public interface ITableRepository
{
    Task<Table?> GetAsync(long id); 
    Task UpdateAsync();
}