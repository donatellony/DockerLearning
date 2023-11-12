using KanbanBoard.Domain.Cards;

namespace KanbanBoard.Domain.Columns;

public class Column
{
    public string Title { get; }
    public IEnumerable<Card> Cards { get; }
}