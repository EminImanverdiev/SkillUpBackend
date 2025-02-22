
using Application.Repositories;
using Domain.Comman;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T>
    where T : BaseEntity
{
    private readonly SkillUpDbContext _context;

    public ReadRepository(SkillUpDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool isTracking)
    {
        var query=Table.AsQueryable();
        if (!isTracking)
        {
            query = query.AsNoTracking();
        }
        return query;
    }

    public IQueryable<T> GetAllWehere(Expression<Func<T, bool>> predicate, bool isTracking, params string[] includes)
    {
        var query = Table.AsQueryable();
        if (!isTracking)
        {
            query = query.AsNoTracking();
        }
        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        return query;   
    }

    public async Task<T> GetByIdAsync(Guid id, bool isTracking, params string[] includes)
    {
        var query = Table.AsQueryable();
        if (isTracking == false)
        {
            query = query.AsNoTracking();
        }
        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        T? entity = await query.FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public async Task<T> GetWhereAsync(Expression<Func<T, bool>> predicate, bool isTracking, params string[] includes)
    {
        var query = Table.AsQueryable();
        if (isTracking == false)
        {
            query = query.AsNoTracking();
        }
        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        T? entity = await query.FirstOrDefaultAsync(predicate);
        return entity;
    }
}