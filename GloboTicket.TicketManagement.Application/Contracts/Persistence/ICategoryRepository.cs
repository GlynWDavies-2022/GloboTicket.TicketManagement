using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence;

public interface ICategoryRepository : IAsyncRepository<Category>
{
    public Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
}
