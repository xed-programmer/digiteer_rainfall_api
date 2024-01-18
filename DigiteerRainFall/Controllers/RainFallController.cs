using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigiteerRainFall.Controllers;

[ApiController]
[Route("[controller]")]
public class RainFallController : ControllerBase
{

    [HttpGet("/id/{stationId}/readings")]
    public async Task<IActionResult> GetStationReadings(string stationId)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "http://environment.data.gov.uk/flood-monitoring/id/stations/3680/readings");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();

        return Ok(responseContent);
    }
}