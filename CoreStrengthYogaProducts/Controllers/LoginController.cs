using Microsoft.AspNetCore.Mvc;

namespace CoreStrengthYogaProducts.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class LoginController : ControllerBase
{
    private readonly ILogger<LoginController> _logger;

    
    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }
    
    /*[HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }*/
    
    
    [HttpPost]
    public IActionResult Login([FromBody] User user)
    {
        _logger.LogError(user.username);
        return Ok();
    }
}