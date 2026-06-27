namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;

public class CategoryListVm
{
    public Guid CategoryId { get; set; }
    public required string Name { get; set; }
}
