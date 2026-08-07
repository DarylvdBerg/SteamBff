using Microsoft.AspNetCore.Mvc;
using AchievementHunter.Application.Abstractions;
using AchievementHunter.Application.Dto;

namespace AchievementHunter.Api.Routes;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}/[controller]")]
public class OwnedGamesController(IOwnedGamesHandler handler) : ControllerBase
{
    [HttpGet, MapToApiVersion("1.0")]
    public async Task<ActionResult<IEnumerable<OwnedGameDto>>> Get(string userId)
    {
        var response = await handler.GetOwnedGames(userId);
        return Ok(response);
    }
}