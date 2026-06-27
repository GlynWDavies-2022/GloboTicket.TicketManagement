namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvent;

public class CategoryEventDto
{
    public Guid EventId { get; set; }
    public required string Name { get; set; }
    public int Price { get; set; }
    public required string Artist { get; set; }
    public DateTime Date { get; set; }
    public Guid CategoryId { get; set; }
}
