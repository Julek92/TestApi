using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Siemanko");
    }
}