using KanbanBoard.Contracts.Boards;
using Microsoft.AspNetCore.Mvc;

namespace KanbanBoard.API.Controllers;

public class KanbanBoardController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetBoardRequest>> GetBoard([FromQuery]GetBoardRequest request)
    {
        await Task.Delay(1);
        return Ok("aaa");
    }
}