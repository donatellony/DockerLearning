using KanbanBoard.Domain.Columns;
using MongoDB.Bson;

namespace KanbanBoard.Domain.Tables;

public class Table
{
    public ObjectId Id { get; set; }
    public string Title { get; }
    public IEnumerable<Column> Columns { get; set; }
}