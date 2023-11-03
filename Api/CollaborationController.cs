using Microsoft.AspNetCore.Mvc;

namespace xuanqi.Api;

[ApiController]
[Route("Shared-Editing-Proposal")]
public class CollaborationController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CollaborationController> _logger;

    public CollaborationController(ILogger<CollaborationController> logger)
    {
        _logger = logger;
    }

    [HttpPost("addSharedTree")]
    public string AddSharedTree()
    {
        return "Hello world";
    }

    [HttpPost("deleteSharedTree")]
    public string DeleteSharedTree()
    {
        return "Hello world";
    }
}
