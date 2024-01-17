using Microsoft.AspNetCore.Mvc;

namespace DigiteerRainFall.Controllers;

[ApiController]
[Route("[controller]")]
public class RainFallController : ControllerBase
{
    [HttpGet("/id/{stationId}/readings")]
    public IActionResult GetStationReadings(string stationId)
    {
        return Ok(stationId);
    }
}