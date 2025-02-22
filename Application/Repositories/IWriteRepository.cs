
using Domain.Comman;
using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Repositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity);
    bool DeleteTemporarily(T entity);
    bool RemovePermanently(T entity);
    bool RecoverData(T entity);
    bool Update(T entity);
    Task<IDbContextTransaction> BeginTransactionAsync(); 
    Task<int> SaveAsync();
    int Save();
}