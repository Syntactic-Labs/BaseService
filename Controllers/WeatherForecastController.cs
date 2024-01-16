using Microsoft.AspNetCore.Mvc;

namespace BaseService.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
	private readonly ILogger<WeatherForecastController> _logger;

	public WeatherForecastController(ILogger<WeatherForecastController> logger) => _logger = logger;

	[HttpGet(Name = "GetWeatherForecast")]
	public async Task<IActionResult> Get() =>  Ok();
}