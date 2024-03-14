using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("[controller]")]
public class ConvertController : ControllerBase
{
  private readonly IConvertService _convertService;
  private readonly ILogger<ConvertController> _logger;

  public ConvertController(IConvertService convertService, ILogger<ConvertController> logger)
  {
    _convertService = convertService;
    _logger = logger;
  }

  [HttpPost]
  public IActionResult Convert([FromBody] string number)
  {
    try
    {
      string text = _convertService.ConvertNumberToText(number);
      return Ok(text);
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "An error occurred while processing the request.");
      return StatusCode(500, "Internal server error");
    }
  }
}