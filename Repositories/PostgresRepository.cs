
using FTELMarket.Api.DbConf;
using FTELMarket.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FTELMarket.Api.Repositories;

public class PostgresRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly PostgresDbContext _context;
    private readonly DbSet<T> _table;

    public PostgresRepository(PostgresDbContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _table.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        var myEntity = await _table.Where(e => e.Id == id).FirstOrDefaultAsync();
        if (myEntity == null)
            throw new Exception($"{typeof(T).Name}s don't have an instance with the id={id}");

        return myEntity;
    }

    public async Task AddAsync(T entity)
    {
        await _table.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _table.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}