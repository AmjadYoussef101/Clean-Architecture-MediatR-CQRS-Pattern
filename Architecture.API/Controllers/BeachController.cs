using Architecture.Application.Beach.GetAllBeachs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BeachController : ControllerBase
{
    private readonly IMediator _mediator;
    public BeachController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var response = await _mediator.Send(new GetAllBeachesRequest());
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync(Application.Beach.CreateBeach.CreateBeachRequest payload)
    {
        var newlyCreateItemId = await _mediator.Send(payload);
        return Ok(newlyCreateItemId);
    }
}
