namespace KanbanBoard.Application.Common.Interfaces;

public interface IUnitOfWork
{
    Task CommitChangesAsync();
}