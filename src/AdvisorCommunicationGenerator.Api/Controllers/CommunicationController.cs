using AdvisorCommunicationGenerator.Api.Application.Contracts;
using AdvisorCommunicationGenerator.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AdvisorCommunicationGenerator.Api.Controllers;

[ApiController]
[Route("api/communication")]
public sealed class CommunicationController : ControllerBase
{
    private readonly ICommunicationService _service;

    public CommunicationController(ICommunicationService service)
    {
        _service = service;
    }

    [HttpPost("generate")]
    public ActionResult<CommunicationResult> Generate([FromBody] CommunicationRequest request)
    {
        return Ok(_service.Generate(request));
    }
}
