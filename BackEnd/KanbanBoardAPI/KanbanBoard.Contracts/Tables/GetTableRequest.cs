using MongoDB.Bson;

namespace KanbanBoard.Contracts.Tables;

public record GetTableRequest(ObjectId Id);