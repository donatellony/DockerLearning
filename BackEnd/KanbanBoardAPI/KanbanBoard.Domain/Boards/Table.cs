using KanbanBoard.Domain.Columns;

namespace KanbanBoard.Domain.Boards;

public class Table
{
    public string Title { get; }
    public IEnumerable<Column> Columns { get; set; }
}