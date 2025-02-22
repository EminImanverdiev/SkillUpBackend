
using Domain.Comman;
using System.Linq.Expressions;

namespace Application.Repositories;

public interface IReadRepository<T>:IRepository<T>
    where T : BaseEntity
{
    IQueryable<T> GetAll(bool isTracking);
    IQueryable<T> GetAllWehere(Expression<Func<T,bool> >predicate,bool isTracking,params string[] includes);
    Task<T> GetByIdAsync(Guid id,bool isTracking,params string[] includes);
    Task<T> GetWhereAsync(Expression<Func<T,bool>> predicate,bool isTracking, params string[] includes);
}
