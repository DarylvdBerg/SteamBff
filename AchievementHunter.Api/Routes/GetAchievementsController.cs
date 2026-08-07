using Microsoft.AspNetCore.Mvc;

namespace AchievementHunter.Api.Routes;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}/[controller]")]
public class GetAchievementsController : ControllerBase
{
    [HttpGet, MapToApiVersion("1.0")]
    public ActionResult<String> Get()
    {
        return Ok("GetAchievements");
    }
}