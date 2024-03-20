using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
  [Route("api/[controller]")]
  [ApiController]
  public class TestController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return Enumerable.Range(1, 5).Select(x => x < 5 ? x.ToString() : DateTime.UtcNow.ToString("yyyMMdd_HHmmss"));
    }
  }
}
