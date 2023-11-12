using MediatR;
using ErrorOr;
using KanbanBoard.Domain.Tables;
using MongoDB.Bson;

namespace KanbanBoard.Application.Tables.Queries;

public record GetTableQuery(ObjectId Id): IRequest<ErrorOr<Table>>;