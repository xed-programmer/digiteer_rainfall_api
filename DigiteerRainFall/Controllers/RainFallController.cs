using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace DigiteerRainFall.Controllers;

[ApiController]
[Route("[controller]")]
public class RainFallController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public RainFallController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
        _httpClient.BaseAddress = new System.Uri("http://environment.data.gov.uk/flood-monitoring");
    }

    [HttpGet("/id/{stationId}/readings")]
    public async Task<IActionResult> GetStationReadings(string stationId)
    {
        var response = await _httpClient.GetAsync("id/stations/1491TH/readings");
        return Ok(response);
    }
}