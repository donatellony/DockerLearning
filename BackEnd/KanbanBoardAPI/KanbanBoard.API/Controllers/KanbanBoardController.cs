using KanbanBoard.Application.Tables.Queries;
using KanbanBoard.Contracts.Tables;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KanbanBoard.API.Controllers;

public class KanbanBoardController : BaseController
{
    private readonly ISender _mediator;

    public KanbanBoardController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<GetTableRequest>> GetBoard([FromQuery]GetTableRequest request)
    {
        var query = new GetTableQuery(request.Id);

        var getTableResult = await _mediator.Send(query);
        
        return getTableResult.Match(
            table => Ok(new TableResponse(table)),
            _ => Problem());
    }
}