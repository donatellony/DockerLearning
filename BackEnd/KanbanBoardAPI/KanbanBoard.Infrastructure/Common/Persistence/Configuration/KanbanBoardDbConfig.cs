namespace KanbanBoard.Infrastructure.Common.Persistence.Configuration;

public class KanbanBoardDbConfig
{
    public string ConnectionString { get; init; } = string.Empty;
    public string DatabaseName { get; init; } = string.Empty;
}