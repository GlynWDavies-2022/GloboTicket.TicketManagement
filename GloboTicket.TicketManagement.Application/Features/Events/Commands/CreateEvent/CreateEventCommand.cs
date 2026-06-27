using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;

public class CreateEventCommand : IRequest<Guid>
{
    public required string Name { get; set; }
    public int Price { get; set; }
    public required string Artist { get; set; }
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public string? ImageUrl { get; set; }
    public Guid CategoryId { get; set; }
    public override string ToString()
    {
        return $"Event name: {Name}; Price: {Price}; By: {Artist}; On: {Date.ToShortDateString()}; Description: {Description}";
    }
}
