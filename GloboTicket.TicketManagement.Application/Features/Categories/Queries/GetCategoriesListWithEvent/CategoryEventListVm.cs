namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvent;

public class CategoryEventListVm
{
    public Guid CategoryId { get; set; }
    public required string Name { get; set; }
    public ICollection<CategoryEventDto> Events { get; set; } = new List<CategoryEventDto>();
}
