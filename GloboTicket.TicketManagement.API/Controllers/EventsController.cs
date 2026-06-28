using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly IMediator _mediator;

    public EventsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllEvents")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult<List<EventListVm>>> GetAllEvents()
    {
        var result = await _mediator.Send(new GetEventsListQuery());

        return Ok(result);
    }

    [HttpGet("{id}", Name = "GetEventById")]
    public async Task<ActionResult<EventDetailVm>> GetEventById(Guid id)
    {
        var getEventDetailQuery = new GetEventDetailQuery() { Id = id };
        return Ok(await _mediator.Send(getEventDetailQuery));
    }
}
