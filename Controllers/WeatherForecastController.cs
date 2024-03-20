using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
  [Route("api/[controller]")]
  [ApiController]
  public class WeatherForecastController : ControllerBase
  {
    public IEnumerable<int> Get()
    {
      return Enumerable.Range(1, 5);
    }
  }
}
