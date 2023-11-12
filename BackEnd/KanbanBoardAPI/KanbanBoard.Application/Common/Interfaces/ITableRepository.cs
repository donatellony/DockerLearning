using KanbanBoard.Domain.Tables;
using MongoDB.Bson;

namespace KanbanBoard.Application.Common.Interfaces;

//TODO change to use the UserId in the future.
public interface ITableRepository
{
    Task<Table?> GetAsync(ObjectId id); 
    Task UpdateAsync();
}