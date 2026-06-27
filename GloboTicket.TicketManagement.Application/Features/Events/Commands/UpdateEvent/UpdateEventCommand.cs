using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;

public class UpdateEventCommand : IRequest
{
    public Guid EventId { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
    public required string Artist { get; set; }
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public string? ImageUrl { get; set; }
    public Guid CategoryId { get; set; }
}
