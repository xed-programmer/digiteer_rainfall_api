using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DigiteerRainFall.DigiteerRainFall.Contracts.RainFall;
namespace DigiteerRainFall.Controllers;

[ApiController]
[Route("[controller]")]
public class RainFallController : ControllerBase
{

    [HttpGet("id/{stationId}/readings")]
    public async Task<IActionResult> GetStationReadings(string stationId)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "http://environment.data.gov.uk/flood-monitoring/id/stations/3680/readings");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var responseContent = await response.Content.ReadAsStringAsync();

        // Deserialize the JSON response into an object
        var readings = JsonSerializer.Deserialize<RainFallResponse>(responseContent, new JsonSerializerOptions{
            PropertyNameCaseInsensitive = true
        });
        return Ok(readings);
    }
}