using KanbanBoard.Domain.Columns;

namespace KanbanBoard.Domain.Tables;

public class Table
{
    public long Id { get; set; }
    public string Title { get; }
    public IEnumerable<Column> Columns { get; set; }
}