using KanbanBoard.Infrastructure.Common.Persistence.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KanbanBoard.Infrastructure.Common.Persistence;

public class KanbanBoardMongoClient : MongoClient
{
    public KanbanBoardMongoClient(IOptions<KanbanBoardDbConfig> options) :
        base(connectionString: options.Value.ConnectionString)
    {
    }
}