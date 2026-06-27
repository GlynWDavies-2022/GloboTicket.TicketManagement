using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence.Persistence;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected readonly GloboTicketDbContext _dbContext;

    public BaseRepository(GloboTicketDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public virtual async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);

        if (entity == null)
        {
            return null!;
        }

        return entity;
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);

        await _dbContext.SaveChangesAsync();
    }
}
