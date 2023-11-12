using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace KanbanBoard.Infrastructure.Common.Persistence.Configuration;

public class KanbanBoardDbConfigSetup : IConfigureOptions<KanbanBoardDbConfig>
{
    private const string SectionName = nameof(KanbanBoardDbConfig);
    private readonly IConfiguration _configuration;

    public KanbanBoardDbConfigSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(KanbanBoardDbConfig options)
    {
        _configuration
            .GetSection(SectionName)
            .Bind(options);
    }
}