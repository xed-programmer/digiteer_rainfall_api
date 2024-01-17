using Microsoft.AspNetCore.Mvc;

namespace DigiteerRainFall.Controllers;

[ApiController]
public class RainFallController : ControllerBase
{
    [HttpGet("/rainfall/id/{stationId}/readings")]
    public IActionResult GetStationReadings(string stationId)
    {
        return Ok(stationId);
    }
}