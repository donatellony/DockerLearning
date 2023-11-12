using ErrorOr;
using KanbanBoard.Application.Common.Interfaces;
using KanbanBoard.Domain.Tables;
using MediatR;

namespace KanbanBoard.Application.Tables.Queries;

public class GetTableQueryHandler : IRequestHandler<GetTableQuery, ErrorOr<Table>>
{
    private readonly ITableRepository _tableRepository;

    public GetTableQueryHandler(ITableRepository tableRepository)
    {
        _tableRepository = tableRepository;
    }

    public async Task<ErrorOr<Table>> Handle(GetTableQuery request, CancellationToken cancellationToken)
    {
        if (await _tableRepository.GetAsync(request.Id) is not Table table)
        {
            return Error.NotFound($"{nameof(Table)} not found");
        }
        return table;
    }
}