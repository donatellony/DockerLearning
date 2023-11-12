using KanbanBoard.Application.Common.Interfaces;
using KanbanBoard.Infrastructure.Common.Persistence;
using KanbanBoard.Infrastructure.Common.Persistence.Configuration;
using KanbanBoard.Infrastructure.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KanbanBoard.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services
            .AddPersistence();
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.ConfigureOptions<KanbanBoardDbConfigSetup>();
        services.AddScoped<IMongoClient, KanbanBoardMongoClient>();
        services.AddDbContext<KanbanBoardDbContext>((serviceProvider, options) =>
            {
                var dbConfig = serviceProvider.GetRequiredService<IOptions<KanbanBoardDbConfig>>();
                var database = serviceProvider.GetRequiredService<IMongoClient>().GetDatabase(dbConfig.Value.DatabaseName);
                options.UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName);
            }
        );
        
        services.AddScoped<ITableRepository, TableRepository>();
        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<KanbanBoardDbContext>());

        return services;
    }
    
}