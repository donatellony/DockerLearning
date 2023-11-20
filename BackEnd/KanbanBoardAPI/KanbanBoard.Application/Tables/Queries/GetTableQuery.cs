using MediatR;
using ErrorOr;
using KanbanBoard.Domain.Tables;

namespace KanbanBoard.Application.Tables.Queries;

public record GetTableQuery(long Id): IRequest<ErrorOr<Table>>;