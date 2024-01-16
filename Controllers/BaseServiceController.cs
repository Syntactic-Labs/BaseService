using Microsoft.AspNetCore.Mvc;

namespace BaseService.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseServiceController : ControllerBase
{
	private readonly ILogger<BaseServiceController> _logger;

	public BaseServiceController(ILogger<BaseServiceController> logger) => _logger = logger;

	[HttpGet(Name = "GetWeatherForecast")]
	public async Task<IActionResult> Get() =>  Ok();
}